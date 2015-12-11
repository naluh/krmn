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
    public partial class Edit : Form
    {
        Form1 f1;
        public Edit(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            int a = f1.Pass;
            DataSet MongolianEdit = new DataSet();
            try
            {
                string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                MySqlConnection conn = new MySqlConnection(connstr);
                {
                    string sql = "SELECT * FROM mongolian where mn_Id = '" + a + "'";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(MongolianEdit, "mongolian");
                }
                foreach (DataRow r in MongolianEdit.Tables[0].Rows)
                {

                    txtMnIdEdit.Text = r["mn_ID"].ToString();
                    txtMnNameEdit.Text = r["mn_Name"].ToString();
                    txtMnPosEdit.Text = r["mn_Pos"].ToString();
                    txtMnSenseTagEdit.Text = r["mn_SenseTag"].ToString();
                    txtMnExplainEdit.Text = r["mn_Explain"].ToString();
                    txtMnExampleEdit.Text = r["mn_Example"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
                MySqlConnection conn = new MySqlConnection(connstr);



                //string sql = "update krmndic.mongolian set mn_Name = '" + this.txtMnNameEdit.Text + "', mn_SenseTag ='" +
                //    this.txtMnSenseTagEdit.Text + "', mn_Pos = '" + this.txtMnPosEdit.Text + "', mn_Explain = '" +
                //this.txtMnExplainEdit.Text + "', mn_Example = '" + this.txtMnExampleEdit.Text + "' where mn_ID='" + this.txtMnIdEdit.Text + "';";

                string sql = string.Format("UPDATE krmndic.mongolian SET "
                    + "mn_name='{0}', mn_sensetag='{1}', mn_pos='{2}', mn_explain='{3}', mn_example='{4}' "
                    + "WHERE mn_id={5}",
                    this.txtMnNameEdit.Text, this.txtMnSenseTagEdit.Text, this.txtMnPosEdit.Text,
                    this.txtMnExplainEdit.Text, this.txtMnExampleEdit.Text, this.txtMnIdEdit.Text
                    );

                MySqlCommand cmdDataBase = new MySqlCommand(sql, conn);
                
                MySqlDataReader myReader;
                conn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data Updated");

                while (myReader.Read())
                { }
                this.Hide();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e) // Cancel
        {
            this.Close();
        }
    }
}
