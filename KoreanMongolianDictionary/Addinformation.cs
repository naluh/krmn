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
    public partial class Addinformation : Form
    {
        
        Form1 display;
        public Addinformation(Form1 display)
        {
            InitializeComponent();
            this.display = display;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
                {
                    string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                    string sql = "insert into krmndic.mongolian(mn_ID,mn_Name,mn_SenseTag,mn_Pos,mn_Explain,mn_Example) value('" +this.txtMnId.Text + "','" +this.txtMnName.Text + "','" +this.txtMnSenseTag.Text + "','" +this.txtMnPos.Text + "','" +this.txtMnExplain.Text + "','" +this.txtMnExample.Text + "');";
                    MySqlConnection conn = new MySqlConnection(connstr);
                    MySqlCommand cmdDataBase = new MySqlCommand(sql, conn);
                    MySqlDataReader myReader;
                    conn.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Saved Data");
                   
                    
                    form1.Show();
                    this.Hide();
                   
                    while (myReader.Read())
                    { }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
