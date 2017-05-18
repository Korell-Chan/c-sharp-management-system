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
        public Main()
        {
            InitializeComponent();
            login log = (login)this.Owner;
            try
            {
                label1.Text = "Hello," + log.textBox1.Text;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}first exception", e.Message);
            }
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
            this.Hide();
            c.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            parts p = new parts();
            this.Hide();
            p.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            service s = new service();
            this.Hide();
            s.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            information i = new information();
            this.Hide();
            i.Show();
        }

        
    }
}
