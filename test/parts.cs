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
    public partial class parts : Form
    {
        public string username;
        public parts()
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string partsname=checkBox1.Text.ToString();
            if (checkBox1.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('"+username+ "','" + t + "','"+partsname+"','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox2.Text.ToString();
            if (checkBox2.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('"+username+"','" + t + "','"+ partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox3.Text.ToString();
            if (checkBox3.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('"+username+"','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox4.Text.ToString();
            if (checkBox4.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('"+username+"','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox5.Text.ToString();
            if (checkBox5.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox6.Text.ToString();
            if (checkBox6.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox7.Text.ToString();
            if (checkBox7.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox8.Text.ToString();
            if (checkBox8.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox9.Text.ToString();
            if (checkBox9.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox10.Text.ToString();
            if (checkBox10.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox11.Text.ToString();
            if (checkBox11.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox21.Text.ToString();
            if (checkBox12.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox13.Text.ToString();
            if (checkBox13.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox14.Text.ToString();
            if (checkBox14.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox15.Text.ToString();
            if (checkBox15.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox16.Text.ToString();
            if (checkBox16.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox17.Text.ToString();
            if (checkBox17.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox18.Text.ToString();
            if (checkBox18.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox19.Text.ToString();
            if (checkBox19.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox20.Text.ToString();
            if (checkBox20.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox21.Text.ToString();
            if (checkBox21.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox22.Text.ToString();
            if (checkBox22.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox23.Text.ToString();
            if (checkBox23.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox24.Text.ToString();
            if (checkBox24.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox25.Text.ToString();
            if (checkBox25.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox26.Text.ToString();
            if (checkBox26.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox27.Text.ToString();
            if (checkBox27.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox28.Text.ToString();
            if (checkBox28.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox29.Text.ToString();
            if (checkBox29.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox30.Text.ToString();
            if (checkBox30.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox31.Text.ToString();
            if (checkBox31.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox32.Text.ToString();
            if (checkBox32.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox33.Text.ToString();
            if (checkBox33.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox34.Text.ToString();
            if (checkBox34.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox35.Text.ToString();
            if (checkBox35.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox36.Text.ToString();
            if (checkBox36.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox37.Text.ToString();
            if (checkBox37.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox38.Text.ToString();
            if (checkBox38.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox39.Text.ToString();
            if (checkBox39.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            string partsname = checkBox40.Text.ToString();
            if (checkBox40.Checked)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                conn.Open();
                string t = DateTime.Now.ToString();
                string sql = "insert into dbo.event(username,time,event,type,flag) values('" + username + "','" + t + "','" + partsname + "','parts','已预购')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }
}
