using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
//NPOI库,操作Excel
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Text.RegularExpressions;

namespace QualificationReviewTool
{
    public partial class Main : Form
    {
        private string blog_url = "https://blog.cuger.cn";

        private IWorkbook work_book = null;
        //考生信息表
        private DataTable examinee_dt = null;
        private String examinee_table_name = "国考入围面试中单";
        //联系方式信息表
        private DataTable user_info_dt = null;
        private String user_info_table_name = "大量数据";
        //汇总表
        private DataTable summary_dt = null;
        private String summary_table_name = "导出";

        private String impoet_file_name = null;
        private String export_file_name = null;

        private Hashtable ht = new Hashtable();

        private delegate void TreadWork(int min, int max, int current, String str);
        private delegate void Refresh_dt();
        private Thread thread;

        public Main()
        {
            InitializeComponent();
            //初始化
            update_btn_status(false);
        }


        /* private函数 */

        private String select_file(String title)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = title;
            dialog.Filter = "Excel文件(*.xls,*.xlsx,*.csv)|*.xls;*.xlsx;*.csv";
            String file = null;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
            }
            return file;
        }

        //保存文件
        private String save_file(String title)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = title;
            if (work_book is HSSFWorkbook)
            {
                //xls
                dialog.Filter = "Excel2003(*.xls)|*.xls";
            }
            else
            {
                //xlsx
                dialog.Filter = "Excel2007(*.xlsx)|*.xlsx";
            }
            dialog.FileName = ""+Path.GetFileNameWithoutExtension(this.impoet_file_name)+"_导出_" + string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
            String file = null;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
            }
            return file;
        }

        private void status_update(int min,int max,int current,String str)
        {
            if (this.InvokeRequired)
            {
                TreadWork fc = new TreadWork(status_update);
                this.Invoke(fc, new object[4] { min,max, current, str });
            }
            else
            {
                this.statusbar_progressbar.Minimum = min;
                this.statusbar_progressbar.Maximum = max;
                this.statusbar_progressbar.Value = current;
                this.statusbar_status.Text = str;
            }
        }

        private void update_datatable()
        {
            if (this.InvokeRequired)
            {
                Refresh_dt fc = new Refresh_dt(update_datatable);
                this.Invoke(fc);
            }
            else
            {
                this.dataGridView1.DataSource = this.summary_dt;
                //this.dataGridView1.BeginEdit(false);
            }
        }

        //将NOPI转为DataTable
        private DataTable export_to_datatable(ISheet sheet, int start_row)
        {
            DataTable dt = new DataTable();

            //默认，第一行是字段
            IRow headRow = sheet.GetRow(start_row);
            int count_col = 0;
            //设置datatable字段
            for (int i = headRow.FirstCellNum, len = headRow.LastCellNum; i < len; i++)
            {
                String tmp_str=headRow.Cells[i].StringCellValue.Replace(" ", "");
                if (!tmp_str.Equals(""))
                {
                    count_col += 1;
                    dt.Columns.Add(tmp_str);
                }
            }
            //遍历数据行
            for (int i = (start_row + 1), len = sheet.LastRowNum + 1; i < len; i++)
            {
                IRow tempRow = sheet.GetRow(i);
                DataRow dataRow = dt.NewRow();

                //遍历一行的每一个单元格
                for (int r = 0, j = 0; j < count_col; j++, r++)
                {

                    ICell cell = tempRow.GetCell(j);

                    if (cell != null)
                    {
                        switch (cell.CellType)
                        {
                            case CellType.String:
                                dataRow[r] = cell.StringCellValue.Replace(" ", "");
                                break;
                            case CellType.Numeric:
                                dataRow[r] = cell.NumericCellValue;
                                break;
                            case CellType.Boolean:
                                dataRow[r] = cell.BooleanCellValue;
                                break;
                            default:
                                dataRow[r] = cell.StringCellValue.Replace(" ", "");
                                break;
                        }
                    }
                }
                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        //将DataTable转为NOPI
        private void datatable_to_excel()
        {
            String sheet_name = this.summary_table_name;
            DataTable dt = (DataTable)summary_dt;
            //若该表存在,则删除表
            /*
            for (int i = 0; i < work_book.NumberOfSheets; i++)
            {
                ISheet tmp_sheet = work_book.GetSheetAt(i);
                if (tmp_sheet.SheetName == sheet_name)
                {
                    work_book.RemoveSheetAt(i);
                }
            }
            */
            //删除原表
            /*for (int i = 0;  i < work_book.NumberOfSheets; i++)
            {
                ISheet tmp_sheet = work_book.GetSheetAt(i);
                if (tmp_sheet.SheetName == this.examinee_table_name || tmp_sheet.SheetName == this.user_info_table_name || tmp_sheet.SheetName == sheet_name)
                {
                    work_book.RemoveSheetAt(i);
                }
            }*/
            XSSFWorkbook export_workbook = new XSSFWorkbook();
            ISheet sheet=export_workbook.CreateSheet(sheet_name);
            //ISheet sheet = work_book.CreateSheet(sheet_name);
            IRow dataRow = sheet.CreateRow(0);
            foreach (DataColumn column in dt.Columns)
            {
                dataRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
            }
            int row_count = dt.Rows.Count;
            //填充内容
            for (int i = 0; i < row_count; i++)
            {
                dataRow = sheet.CreateRow(i + 1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dataRow.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
                status_update(0, row_count, i, "Current:" + i + "/" + row_count + "(" + string.Format("{0:0.00%}", Convert.ToDouble(i) / Convert.ToDouble(row_count)) + "). Please wait.");
            }
            status_update(0, row_count, row_count, "Start writing to the file.");
            using (FileStream fs = new FileStream(this.export_file_name, FileMode.Create, FileAccess.Write))
            {
                export_workbook.Write(fs);
                fs.Close();
            }
            status_update(0, row_count, row_count, "Finish ! File name:" + Path.GetFileName(this.export_file_name));
        }

        //导入文件
        private void import_file()
        {
            //选择Excel文件
            this.impoet_file_name = this.select_file("打开Excel文件");
            if (this.impoet_file_name == null)
            {
                //未打开文件
                status_update(0,1,0," 未选择文件!");
            }
            else
            {
                status_update(0, 1, 0, this.impoet_file_name + " 打开成功!");
                //打开该文件
                using (FileStream fs = File.Open(this.impoet_file_name, FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite))
                {
                    //把xls文件读入workbook变量里，之后就可以关闭了
                    String extension = System.IO.Path.GetExtension(this.impoet_file_name);
                    if (extension.Equals(".xls"))
                    {
                        this.work_book = new HSSFWorkbook(fs);
                    }
                    else
                    {
                        this.work_book = new XSSFWorkbook(fs);
                    }
                    fs.Close();
                    status_update(0, 1, 0, this.impoet_file_name + "文件读取成功!");
                }
                thread = new Thread(match_sms);
                thread.Start();
                //更新按键状态
                update_btn_status(true);
            }
        }

        //导出当前DataTable
        private void export_file()
        {
            //选择Excel文件
            this.export_file_name = this.save_file("导出Excel文件");
            if (this.export_file_name == null)
            {
                //未打开文件
                status_update(0, 1, 0, " 未选择文件!");
            }
            else
            {
                status_update(0, 1, 0, this.export_file_name + " 选择成功!");
                thread = new Thread(datatable_to_excel);
                thread.Start();
            }
        }

        private void match_sms()
        {
            //解析数据
            status_update(0, 1, 0, "开始解析数据...");
            this.examinee_dt = this.export_to_datatable(this.work_book.GetSheet(this.examinee_table_name), 0);
            this.user_info_dt = this.export_to_datatable(this.work_book.GetSheet(this.user_info_table_name), 0);
            this.summary_dt = new DataTable();

            status_update(0, 1, 0, "正在检查列名是否符合...");
            ArrayList col_list=new ArrayList();
            col_list.Add("准考证号");
            col_list.Add("考生姓名");
            col_list.Add("部门代码");
            col_list.Add("报考部门");
            col_list.Add("报考职位代码");
            col_list.Add("报考职位名称");
            col_list.Add("最低面试分数");
            ArrayList col_list2=new ArrayList();
            col_list2.Add("姓名");
            col_list2.Add("电话");

            if(!(check_col_name(this.examinee_dt,col_list) && check_col_name(this.user_info_dt,col_list2))){
                //检查未通过
                status_update(0, 1, 1, "列名检查未通过!");
            }
            else
            {
                status_update(0, 1, 0, "开始匹配数据...");
                //剔除没有名字的行
                for (int i = 0; i < this.examinee_dt.Rows.Count; )
                {
                    //判断名字是否为空
                    if (string.IsNullOrEmpty(this.examinee_dt.Rows[i]["考生姓名"].ToString()))
                    {
                        examinee_dt.Rows.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                // 增加列
                this.summary_dt.Columns.Add("姓名");
                this.summary_dt.Columns.Add("手机号");
                //this.summary_dt.Columns.Add("描述");
                this.summary_dt.Columns.Add("解决方案");

                int row_count = this.user_info_dt.Rows.Count;
                //两表匹配,展示结果,以手机号表为基准
                for (int i = 0; i < row_count; i++)
                {
                    //匹配名字,获取考试信息
                    DataRow[] match_result = this.match_info_by_name(this.examinee_dt, this.user_info_dt.Rows[i]["姓名"].ToString());
                    DataRow match_row = null;
                    DataRow dataRow = this.summary_dt.NewRow();
                    //姓名
                    dataRow[0] = this.user_info_dt.Rows[i]["姓名"];
                    //电话
                    dataRow[1] = this.user_info_dt.Rows[i]["电话"];
                    if (match_result.Count() == 1)
                    {
                        //成功匹配到
                        match_row = (DataRow)match_result[0];
                        //描述
                        /*
                        dataRow[2] = "未报名,学员" + match_row["姓名"]
                            + ",报考岗位:" + match_row["招录职位"]
                            + ",招录" + match_row["招录计划"] + "人"
                            + ",考了" + match_row["笔试折算分"] + "分"
                            + ",排第" + match_row["笔试排名"] + "名"
                            + ",职位代码" + match_row["职位代码"];
                         * */
                        //解决方案
                        //String status = (int.Parse(match_row["笔试排名"].ToString()) > int.Parse(match_row["招录计划"].ToString())) ? "翻盘" : "状元";
                        //dataRow[3] = "#name#,推荐#recommend#(" + status + "),预计回访#visit_time#";
                        //dataRow[2] = dataRow[0]+",推荐#recommend#,预计回访#visit_time#";
                        dataRow[2] ="#name#,推荐#recommend#,预计回访#visit_time#";
                        this.summary_dt.Rows.Add(dataRow);
                    }
                    else if (match_result.Count() == 0)
                    {
                        //未匹配到
                        dataRow[2] = "未查询到该生信息!";
                        //dataRow[3] = "#name#,推荐#recommend#(" + "未匹配" + "),预计回访#visit_time#";
                    }
                    else
                    {
                        //大于1,多个匹配
                        dataRow[2] = "该姓名存在多条记录!请人工处理!";
                        //dataRow[3] = "#name#,推荐#recommend#(" + "多条匹配" + "),预计回访#visit_time#";
                        this.summary_dt.Rows.Add(dataRow);
                    }
                    //更新进度条和状态栏
                    status_update(0, row_count, i, "Current:" + i + "/" + row_count + "(" + string.Format("{0:0.00%}", Convert.ToDouble(i) / Convert.ToDouble(row_count)) + "). Please wait.");
                }
                status_update("匹配完成,匹配到" + this.summary_dt.Rows.Count+ "条数据.");
                //展示结果
                update_datatable();
            }
        }

        private Boolean check_col_name(DataTable dt,ArrayList list)
        {
            int[] col_match_count = new int[list.Count];//创建相同大小的数组
            foreach (object item in list)
            {
                //分析列名是否存在
                foreach (DataColumn dc in dt.Columns)
                {
                    //每一列,分析列名
                    if (dc.ColumnName == item.ToString())
                    {
                        //找到匹配值
                        col_match_count[list.IndexOf(item)] = 1;
                        break;
                    }
                }
            }
            if (col_match_count.Sum() != list.Count)
            {
                String ept_col = "";
                for (int i = 0; i < col_match_count.Length; i++)
                {
                    if (col_match_count[i] != 1)
                    {
                        ept_col += list[i] + "\n";
                    }
                }
                //缺少列
                MessageBox.Show("列名匹配失败!\n请检查以下列名是否存在,或列名存在换行!\n\n需要检查的列名:\n" + ept_col,
                    "列名检测失败",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0);
                return false;
            }
            else
            {
                return true;
            }
        }

        //搜索对应关系
        private DataRow[] match_info_by_name(DataTable dt,String name)
        {
            return dt.Select("考生姓名='"+name+"'");
        }

        //退出程序提示
        private Boolean exit()
        {
            DialogResult MsgBoxResult;//设置对话框的返回值  
            MsgBoxResult = MessageBox.Show("确定要退出程序吗?",//对话框的显示内容   
            "退出提示",//对话框的标题   
            MessageBoxButtons.YesNo,//定义对话框的按钮，这里定义了YSE和NO两个按钮   
            MessageBoxIcon.Exclamation,//定义对话框内的图表式样，这里是一个黄色三角型内加一个感叹号   
            MessageBoxDefaultButton.Button2);//定义对话框的按钮式样  
            if (MsgBoxResult == DialogResult.Yes)//如果对话框的返回值是YES（按"Y"按钮）  
            {
                //Yes
                return true;
            }
            else
            {
                return false;
            }
        }

        private void status_update(String msg)
        {
            this.statusbar_status.Text = msg;
        }

        /* 前端事件 */

        private void import_btn_Click(object sender, EventArgs e)
        {
            //导入文件
            this.import_file();
        }

        private void statusbar_about_Click(object sender, EventArgs e)
        {
            //关于作者
            System.Diagnostics.Process.Start(blog_url);
        }

        private void about_Click(object sender, EventArgs e)
        {
            //关于作者,显示作者信息对话框
            //System.Diagnostics.Process.Start(blog_url);
            Form about_form = new about();
            about_form.ShowDialog();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            //退出程序
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.exit())
            {
                e.Cancel = true;
            }
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            this.export_file();
        }
        //双击修改
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //打开新窗口,语句参数
            DataGridView tempGdv = sender as DataGridView;//获取事件发送者
            //返回值赋值更改
            if (e.RowIndex > -1 && e.ColumnIndex > -1)//防止 Index 出错
            {
                //获取字符串
                String tempStr = tempGdv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //打开新窗口
                Form edit_cell_win = new EditCellWin(
                    tempGdv.Rows[e.RowIndex].Cells[2].Value.ToString()
                    );
                if (edit_cell_win.ShowDialog() == DialogResult.OK)
                {
                    //修改所有行的解决方案
                    for (int i = 0; i < tempGdv.Rows.Count; i++)
                    {
                        String base_str = tempGdv.Rows[i].Cells[2].Value.ToString();
                        //正则提取解决方案内容
                        //改名
                        base_str=Regex.Replace(base_str, @"^[\u4e00-\u9fa5 _#a-zA-Z]*,推荐", EditCellWin.name_value + ",推荐");
                        base_str = Regex.Replace(base_str, @",推荐[\u4e00-\u9fa5 _#0-9a-zA-Z]*\,", ",推荐" + EditCellWin.s_time_value + ",");
                        base_str = Regex.Replace(base_str, @",预计回访[\u4e00-\u9fa5 \._#0-9a-zA-Z]*$", ",预计回访" + EditCellWin.rc_time_value);
                        tempGdv.Rows[i].Cells[2].Value = base_str;
                    }
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.summary_dt = null;
            this.dataGridView1.DataSource = null;
            //更新按键状态
            update_btn_status(false);
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //打开新窗口,语句参数
            DataGridView tempGdv = this.dataGridView1;
            //返回值赋值更改
            if (tempGdv.CurrentRow.Index > -1 && tempGdv.CurrentRow.Index > -1)//防止 Index 出错
            {
                //获取字符串
                String tempStr = tempGdv.Rows[tempGdv.CurrentRow.Index].Cells[2].Value.ToString();
                //打开新窗口
                Form edit_cell_win = new EditCellWin(
                    tempStr
                    );
                if (edit_cell_win.ShowDialog() == DialogResult.OK)
                {
                    //修改所有行的解决方案
                    for (int i = 0; i < tempGdv.Rows.Count; i++)
                    {
                        String base_str = tempGdv.Rows[i].Cells[2].Value.ToString();
                        //正则提取解决方案内容
                        //base_str = Regex.Replace(base_str, @"^[\u4e00-\u9fa5 _#a-zA-Z]*,推荐", EditCellWin.name_value + ",推荐");
                        base_str = Regex.Replace(base_str, @",推荐[\u4e00-\u9fa5 _#0-9a-zA-Z]*\(", ",推荐" + EditCellWin.s_time_value + "(");
                        base_str = Regex.Replace(base_str, @",预计回访[\u4e00-\u9fa5 \._#0-9a-zA-Z]*$", ",预计回访" + EditCellWin.rc_time_value);
                        tempGdv.Rows[i].Cells[2].Value = base_str;
                    }
                }
            }
        }

        private void update_btn_status(Boolean r)
        {
            this.insert_btn.Enabled = r;
            this.export_btn.Enabled = r;
            this.clear_btn.Enabled = r;
            this.clear_ToolStripMenuItem.Enabled = r;
            this.insert_ToolStripMenuItem.Enabled = r;
            this.export_ToolStripMenuItem.Enabled = r;
        }
    }
}
