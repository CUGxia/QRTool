using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QualificationReviewTool
{
    public partial class EditCellWin : Form
    {
        public static String name_value = "";
        public static String s_time_value = "";
        public static String rc_time_value = "";

        public EditCellWin(String solution)
        {
            InitializeComponent();
            /* 初始化，导入信息 */
            //基本信息
            /*this.name_textbox.Text = base_info["姓名"].ToString();
            this.mobile_num_textbox.Text = base_info["准考证号"].ToString();
            this.score_textbox.Text = base_info["笔试折算分"].ToString();
            this.rank_textbox.Text = base_info["笔试排名"].ToString() + "/" + base_info["招录计划"].ToString();
            this.position_textbox.Text = base_info["招录职位"].ToString();
            this.department_textbox.Text = base_info["招录机关"].ToString();
             * */
            //解决方案
            this.solution_textbox.Text = solution;
            //正则提取解决方案内容
            Regex reg = new Regex(@"^(?<name>[\u4e00-\u9fa5 _#a-zA-Z]*),推荐(?<s_time>[\u4e00-\u9fa5 _#a-zA-Z0-9]*),预计回访(?<s_time_p>[\u4e00-\u9fa5 _#0-9a-zA-Z\.]*)$");
            Match match = reg.Match(solution);
            if (match.Success)
            {
                this.s_name_textbox.Text = match.Groups["name"].Value;
                this.s_time_text_box.Text = match.Groups["s_time"].Value;
                DateTime date_time = new DateTime();
                if (DateTime.TryParseExact(match.Groups["s_time_p"].Value, "yyyy.MM.dd", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, out date_time))
                    this.s_time_picker.Value = date_time;
            }
        }

        private void EditCellWin_Load(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            /* OK btn */
            //检查是否符合
            if (!this.check_fill())
            {
                //不符合
                this.DialogResult = DialogResult.None;
                //Console.WriteLine("不符合条件");
            }
            else
            {
                //符合
                //Console.WriteLine("符合条件");
                name_value = this.s_name_textbox.Text;
                s_time_value = this.s_time_text_box.Text;
                rc_time_value = s_time_picker.Value.ToString("yyyy.MM.dd");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        //检查填写情况
        private Boolean check_fill()
        {
            //检查手机号
            //|| !System.Text.RegularExpressions.Regex.IsMatch(this.mobile_num_textbox.Text, @"^^1[345678]\d{9}$$")
            String msg = "";
            if(this.s_name_textbox.Text == ""){
                //负责人员为空
                msg="负责人员不能为空!";
            }
            else if (this.s_time_text_box.Text == "")
            {
                //推荐时间为空
                msg="推荐时间不能为空!";
            }
            else
            {
                //通过检查
                msg = "";
            }
            if (msg == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(msg);
                return false;
            }
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void s_name_textbox_TextChanged(object sender, EventArgs e)
        {
            //更新解决方案
            update_solution_textbox(0);
        }

        private void s_time_text_box_TextChanged(object sender, EventArgs e)
        {
            //更新解决方案
            update_solution_textbox(1);
        }

        private void s_time_picker_ValueChanged(object sender, EventArgs e)
        {
            //更新解决方案
            update_solution_textbox(2);
        }
        //更新solutin_textbox
        private void update_solution_textbox(int type)
        {
            String base_str = this.solution_textbox.Text;
            String name=this.s_name_textbox.Text;
            String s_time=this.s_time_text_box.Text;
            DateTime s_time_picker = this.s_time_picker.Value;

            //正则匹配,分别正则替换相关项
         if (type==0)
            {
                //base_str = Regex.Replace(base_str, @"^[\u4e00-\u9fa5 _#a-zA-Z]*,推荐", name + ",推荐");
            }
            if (type == 1)
            {
                base_str = Regex.Replace(base_str, @",推荐[\u4e00-\u9fa5 _#0-9a-zA-Z]*,", ",推荐" + s_time + ",");
            }
            if (type == 2)
            {
                base_str = Regex.Replace(base_str, @",预计回访[\u4e00-\u9fa5 \._#0-9a-zA-Z]*$", ",预计回访" + s_time_picker.ToString("yyyy.MM.dd"));
            }
            this.solution_textbox.Text = base_str;
        }
    }
}
