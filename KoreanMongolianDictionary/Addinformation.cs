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

        Form1 f;
        public Addinformation(Form1 f)
        {
            InitializeComponent();
            this.f = f;
           
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


            DataSet koreanview = new DataSet();
            try
            {
                string connstr1 = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                MySqlConnection conn1 = new MySqlConnection(connstr1);
                int a = f.PassKorean;
                {
                    string sql = "SELECT * FROM uwin where KeyID = '" + a + "'";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn1);
                    adpt.Fill(koreanview, "uwin");
                }
                foreach (DataRow r in koreanview.Tables[0].Rows)
                {
                    txtMnSenseTag.Text = r["senseTag"].ToString();
                    
                    string pos = r["Pos"].ToString();
                    if (pos == "[명사]")
                    {
                        txtMnPos.Text = "Нэр үг";
                    }
                    else if (pos == "[동사]")
                    {
                        txtMnPos.Text = "Үйл үг";
                    }
                    else if (pos == "[형용사]")
                    {
                        txtMnPos.Text = "Тэмдэг нэр";
                    }
                    else
                    { txtMnPos.Text = ""; }
                    
                    
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                MySqlConnection conn = new MySqlConnection(connstr);
                

                string sql = "insert into krmndic.mongolian(mn_ID,mn_Name,mn_SenseTag,mn_Pos,mn_Explain,mn_Example) value('" + 
                    this.txtMnId.Text + "','" + this.txtMnName.Text + "','" + this.txtMnSenseTag.Text + "','" + 
                    this.txtMnPos.Text + "','" + this.txtMnExplain.Text + "','" + this.txtMnExample.Text + "');";
                
                MySqlCommand cmdDataBase = new MySqlCommand(sql, conn);
              
                MySqlDataReader myReader;
               
                conn.Open();
                myReader = cmdDataBase.ExecuteReader();
                
             
                //MessageBox.Show("Saved Data");

                this.Hide();

                while (myReader.Read())
                { }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                MySqlConnection conn = new MySqlConnection(connstr);
                int b = f.PassKorean;

                
                string sql2 = "insert into krmndic.kr_mn(kr_Id, mn_Id) value('" + b + "','" + this.txtMnId.Text + "');";
                
                MySqlCommand cmdDataBase1 = new MySqlCommand(sql2, conn);
                
                MySqlDataReader myReader1;
                conn.Open();
                
                myReader1 = cmdDataBase1.ExecuteReader();

                MessageBox.Show("Saved Data");

                this.Hide();

                while (myReader1.Read())
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
