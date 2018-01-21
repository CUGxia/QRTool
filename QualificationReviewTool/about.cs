using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualificationReviewTool
{
    public partial class about : Form
    {
        private String blog_url = "https://blog.cuger.cn";
        public about()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(blog_url);
        }
    }
}
