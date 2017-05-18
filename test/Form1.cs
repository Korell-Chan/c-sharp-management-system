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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup sp = new Signup();
            sp.Show();
        }
        int t=219,flag=0,x1=19,y1=118;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.button2.Height != 60)
            {
                this.button2.Height = this.button2.Height + 2;
                this.button2.Width = this.button2.Width + 2;
                this.button2.Top -= 1;
            }
            else {
                this.button2.Height = 30;
                this.button2.Width = 82;
                this.button2.Top = 281;
            }
            
            if (x1 != t)
            {
                
                if (flag == 0)
                {

                    x1 += 2;
                }
                else
                {
                    x1 -= 2;
                }
            }
            else
            {
                if (flag == 0)
                {
                    t = 19;
                    flag = 1;
                }
                else
                {
                    t = 219;
                    flag = 0;
                }
            }
            this.label2.Location = new Point(x1, y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (1 == 1)
            {
                
                this.Hide();
                Main main = new Main();
                main.Owner = this;
                main.Show();
            }
        }
    }
}
