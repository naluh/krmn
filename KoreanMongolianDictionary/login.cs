using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KoreanMongolianDictionary
{
    public partial class login : Form
    {
        MySqlConnection conn;
        static string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";

        public MySqlConnection getConn()
        {
            if( conn == null || conn.State != ConnectionState.Connecting )
            {
                try
                {
                    conn = new MySqlConnection(connstr);
                }
                catch (MySqlException e)
                {
                    System.Windows.Forms.MessageBox.Show("DB접속 오류\n" + e);
                    conn = null;
                }
            }
            return conn;
        }

        public login()
        {
            
            InitializeComponent();

            getConn();

           

        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                Form1 form1 = new Form1(this);
                form1.Show();
                form1.txtSearchFocus();
                this.Hide();

                
            }

        }
        private bool CheckData()
        {
            if (this.txtUsername.Text == "")
            {
                MessageBox.Show("로그인 아이디를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Focus();
                return false;
            }
            else if (this.txtPassword.Text == "")
            {
                MessageBox.Show("로그인 비밀번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return false;
            }
            else
            {
                if (this.txtUsername.Text == "hulan")
                {
                    if (this.txtPassword.Text == "0126")

                        return true;
                    else
                    {
                        MessageBox.Show("일치하는 비밀번호가 없습니다");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("일치하는 아이디가 없습니다");
                    return false;
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void login_Shown(object sender, EventArgs e)
        {
            txtUsername.Text = "hulan";
            txtPassword.Text = "0126";
            btnLogin_Click(null, null);
        }

       

       

  

        

        
    }
}
