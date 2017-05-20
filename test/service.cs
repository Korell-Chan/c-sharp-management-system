using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class service : Form
    {
        public string username;
        public service()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.user = username;
            this.Hide();
            main.Show();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please call this number:111-1111-1111","after-sale phone number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("哈哈哈","抱歉，暂无此功能");
        }

        private void service_Load(object sender, EventArgs e)
        {
            this.label2.Text = username + "先生/女士";
        }
    }
}
