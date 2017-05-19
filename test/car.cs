using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace test
{
    public partial class car : Form
    {
        public string username;
        public car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            conn.Open();
            string t = DateTime.Now.ToString();
            string sql = "insert into dbo.event(username,time,event,type,flag) values('"+username+"','"+t+"','柯尼塞格one1','car','已预购')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            conn.Open();
            string t = DateTime.Now.ToString();
            string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "''," + t + "','LykanHypersport','car','已预购')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            conn.Open();
            string t = DateTime.Now.ToString();
            string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','迈巴赫exelero','car','已预购')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            conn.Open();
            string t = DateTime.Now.ToString();
            string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','西尔贝','car','已预购')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Main main = new Main();
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
        
    }
}
