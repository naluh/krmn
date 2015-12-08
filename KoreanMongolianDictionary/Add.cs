using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoreanMongolianDictionary
{
    public partial class AddWord_mn : Form
    {
        Form1 display;
        public AddWord_mn(Form1 display)
        {
            InitializeComponent();
            this.display = display;
        }
        //try
        //    {
        //        MySqlConnection conn = lo.getConn();
        //        if (conn == null)
        //        {
        //            return;
        //        }
        //        string sql = "insert into krmndic.mongolian(mn_ID,mn_Name,mn_SenseTag,mn_Pos,mn_Explain,mn_Example) values('" +idgiin utga + "','" +txtMnName + "',);";
        //        MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
        //         adpt.Fill(deleteResult, "mongolian");
        //        MySqlCommand cmdDataBase = new MySqlCommand(sql, conn);
        //        MySqlDataReader myReader;
        //        conn.Open();
        //        myReader = cmdDataBase.ExecuteReader();
        //        MessageBox.Show("Data Deleted");
        //        lvMongolian.Clear();
        //        txtExplainMn.Text = "";
        //        txtExampleMn.Text = "";
        //        while (myReader.Read())
        //        { }
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

    }
}
