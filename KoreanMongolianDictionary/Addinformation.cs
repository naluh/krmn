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
        login lo;
        public Addinformation(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            this.lo = f.lo;
            MySqlConnection conn = lo.getConn();
            
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
                MySqlConnection conn1 = lo.getConn();
                if (conn1 == null)
                {
                    return;
                }
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
                    else if (pos == "[부사]")
                    {
                        txtMnPos.Text = "Дайвар үг";
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



        public void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn1 = lo.getConn();
                if (conn1 == null)
                {
                    return;
                }
                

                string sql = "insert into krmndic.mongolian(mn_ID,mn_Name,mn_SenseTag,mn_Pos,mn_Explain,mn_Example) value('" + 
                    this.txtMnId.Text + "','" + this.txtMnName.Text + "','" + this.txtMnSenseTag.Text + "','" + 
                    this.txtMnPos.Text + "','" + this.txtMnExplain.Text + "','" + this.txtMnExample.Text + "');";
                
                MySqlCommand cmdDataBase = new MySqlCommand(sql, conn1);
              
                MySqlDataReader myReader;
               
                conn1.Open();
                myReader = cmdDataBase.ExecuteReader();
                
             
                //MessageBox.Show("Saved Data");

                this.Hide();

                while (myReader.Read())
                { }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                MySqlConnection conn1 = lo.getConn();
                if (conn1 == null)
                {
                    return;
                }
                int b = f.PassKorean;

                
                string sql2 = "insert into krmndic.kr_mn(kr_Id, mn_Id) value('" + b + "','" + this.txtMnId.Text + "');";
                
                MySqlCommand cmdDataBase1 = new MySqlCommand(sql2, conn1);
                
                MySqlDataReader myReader1;
                conn1.Open();
                
                myReader1 = cmdDataBase1.ExecuteReader();

                MessageBox.Show("Saved Data");

                this.Hide();

                while (myReader1.Read())
                { }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f.lvKorean_SelectedIndexChanged(sender, e);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
