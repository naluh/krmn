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
	public partial class AddWord1 : Form
	{
		Form1 f;
		login lo;
		Addinformation AI;
		public AddWord1(Form1 f)
		{
			InitializeComponent();
			this.lo = f.lo;
			this.AI = AI;
			this.f = f;

			txtkrId.Text = f.PassKorean.ToString();
			txtkrName.Text = f.get_kr_Name();
			txt_krSN.Text = f.lvKorean.SelectedItems[0].SubItems[3].Text;
		}

		DataSet Result = new DataSet();
		private void btnAddWord1_Click(object sender, EventArgs e)   // mongol ug haih tovch
		{
			string mnword = txtAddWord1.Text;
			MySqlConnection conn = lo.getConn();
			if (conn == null)
			{
				return;
			}
			{
				string sql = "SELECT * FROM krmndic.mongolian where mn_Name = '" + mnword + "'";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(Result, "mongolian");
			}
			foreach (DataRow r in Result.Tables[0].Rows)
			{
				this.txtMnId.Text = r["mn_ID"].ToString();
				this.txtMnName.Text = r["mn_Name"].ToString();

			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			MySqlConnection conn1 = lo.getConn();
			if (conn1 == null)
			{
				return;
			}
			int b = f.PassKorean;
			try
			{

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
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}