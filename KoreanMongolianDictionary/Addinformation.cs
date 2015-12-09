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
           
            string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
            MySqlConnection conn = new MySqlConnection(connstr);
            
            string max = "select max(mn_Id) from mongolian";
            MySqlCommand cmd = new MySqlCommand(max,conn);
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            
            while (rdr.Read())
            {
                int maxadd = Convert.ToInt32(rdr[0]);
                this.txtMnId.Text = (maxadd+1).ToString();

            }
            conn.Close();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                MySqlConnection conn = new MySqlConnection(connstr);


                string sql = "insert into krmndic.mongolian(mn_ID,mn_Name,mn_SenseTag,mn_Pos,mn_Explain,mn_Example) value('" + this.txtMnId.Text + "','" + this.txtMnName.Text + "','" + this.txtMnSenseTag.Text + "','" + this.txtMnPos.Text + "','" + this.txtMnExplain.Text + "','" + this.txtMnExample.Text + "');";
                MySqlCommand cmdDataBase = new MySqlCommand(sql, conn);

                MySqlDataReader myReader;
                conn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved Data");



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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
