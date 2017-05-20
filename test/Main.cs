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
    public partial class Main : Form
    {
        public string user;
        string u;
        public Main()
        {
            InitializeComponent();
            login log = (login)this.Owner;
            /*try
            {
                label1.Text = "Hello," + user;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}first exception", e.Message);
            }*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            login log = new login();
            this.Hide();
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            car c = new car();
            c.username = user;
            this.Hide();
            c.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            parts p = new parts();
            p.username = user;
            this.Hide();
            p.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            service s = new service();
            s.username = user;
            this.Hide();
            s.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            information i = new information();
            i.username = user;
            this.Hide();
            i.Show();
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

        private void Main_Load(object sender, EventArgs e)
        {
            u = "Hello," + user;
            this.label1.Text = u;
        }

        
    }
}
