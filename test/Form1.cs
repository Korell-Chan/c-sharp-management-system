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
    public partial class login : Form
    {
        public string username = "";
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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            conn.Open();
            string user = textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();
            
            string sqlstr = "select password from dbo.customer where username = '"+user+"'";

            /*SqlCommand cmd = new SqlCommand(sqlstr,conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Close();

            string pw = Convert.ToString(cmd.ExecuteScalar());*/
            
            
            /*string pw = string.Empty;
            SqlCommand getValueCom = conn.CreateCommand();
            getValueCom.CommandText = "select password from dbo.customer where username = '" + user + "'" ;
            SqlDataReader getValueReader = getValueCom.ExecuteReader();
            if (getValueReader.Read())
            {
                pw = Convert.ToString(getValueReader["password"]);

            }
            getValueReader.Close();*/

            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            string pw = ds.Tables[0].Rows[0]["password"].ToString();
            
            if (pass == pw)
            {
                username = textBox1.Text.ToString();
                this.Hide();
                Main main = new Main();
                main.Owner = this;
                main.user = username;
                main.Show();
            }
            else {
                MessageBox.Show("Username or password wrong!Please enter again!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            conn.Close();

            
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
