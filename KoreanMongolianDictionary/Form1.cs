﻿using System;
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
    public partial class Form1 : Form
    {
        public login lo;
        public Form1(login lo)
        {
            InitializeComponent();
            this.lo = lo;

        }

        public void txtSearchFocus()
        {
            txtSearch.Focus();
        }

        DataSet koreanResult = new DataSet();
       
        
        private void btnSearch_Click(object sender, EventArgs e)
        {


            koreanResult.Clear();
            lvKorean.Items.Clear();
            lvMongolian.Items.Clear();
            txtExplainMn.Text = "";
            txtExplainKr.Text = "";
            txtExampleKr.Text = "";
            txtExampleMn.Text = "";

            string searchword = this.txtSearch.Text;
            UpdateRecentSearchWordList(searchword);
            searchword = searchword.Trim();


            // string connstr = "Server = localhost; Database = krmndic; Uid =  root; PWd = 0126;";
            // using (MySqlConnection conn = new MySqlConnection(connstr))
            MySqlConnection conn = lo.getConn();
            if (conn == null)
            {
                return;
            }
            {
                string sql = "SELECT * FROM uwin where name = '" + searchword + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(koreanResult, "uwin");
            }
            foreach (DataRow r in koreanResult.Tables[0].Rows)
            {

                ListViewItem lvi = new ListViewItem(r["keyID"].ToString());
                lvi.SubItems.Add(r["Name"].ToString());
                lvi.SubItems.Add(r["POS"].ToString());
                lvi.SubItems.Add(r["SenseTag"].ToString());
                lvKorean.Items.Add(lvi);
            }
        }

		public string get_kr_Name()
		{
			if (lvKorean.SelectedItems.Count == 0) 
				return "";
			return lvKorean.SelectedItems[0].SubItems[1].Text;
		}

        private void UpdateRecentSearchWordList(string searchword)
        {

            searchword = searchword.Trim();


            //var items = lvLastSearch.Items;
            //  var last = items[items.Count - 1];
            //  last.EnsureVisible();  
            //
            //  string lastword = Convert.ToString( this.lvLastSearch.Items.Count - 1);
            // lvLastSearch.Items[lvLastSearch.Items.Count - 1].EnsureVisible();
            if (lvLastSearch.Items.Count > 0)
            {
                for (int i = 0; i < lvLastSearch.Items.Count; i++)
                {
                    string last = lvLastSearch.Items[i].Text;
                    if (last == searchword)
                    {
                        return ;
                    }

                }

            }
            if (lvLastSearch.Items.Count < 5)
            {
                lvLastSearch.Items.Add(searchword);
            }
            else
            {
                lvLastSearch.Items[0].Remove();
                lvLastSearch.Items.Add(searchword);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            lo.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvKorean.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택되어야 추가할 수 있습니다. ");
                return ;
            }
            //this.Hide();
            
            Addinformation adddata = new Addinformation(this);
            adddata.ShowDialog();
        }
        public int PassKorean
        {
            get { 
				return Convert.ToInt32(lvKorean.SelectedItems[0].Text);
			}
        }

       
        public  void lvKorean_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lvMongolian.Items.Clear();
            txtExplainKr.Text = "";
            txtExampleKr.Text = "";
            txtExplainMn.Text = "";
            txtExampleMn.Text = "";
            if (lvKorean.SelectedItems.Count == 0)
            {
                return ;
            }
            int koreankey = Convert.ToInt32(lvKorean.SelectedItems[0].Text);

            // MessageBox.Show(lvKorean.SelectedItems[0].Text);
            //lvKorean.Items[]
            MySqlConnection conn1 = lo.getConn();
            if (conn1 == null)
            {
                return ;
            }
            DataSet koreanEx = new DataSet();
            {
                string sql = "SELECT * FROM uwin where KeyID = '" + koreankey + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn1);
                adpt.Fill(koreanEx, "uwin");
                foreach (DataRow r in koreanEx.Tables[0].Rows)
                {

                   txtExplainKr.Text =  r["Explain1"].ToString();
                   txtExampleKr.Text = r["Bigo"].ToString();
                }
            }
            MySqlConnection conn = lo.getConn();
            if (conn == null)
            {
                return;
            }

            DataSet MongolianResult = new DataSet();
            {
                string sql = "SELECT * FROM kr_mn where kr_Id = '" + koreankey + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(MongolianResult, "kr_mn");
            }
            string mn_id = "";
            foreach (DataRow r in MongolianResult.Tables[0].Rows)
            {

                ListViewItem lvi = new ListViewItem(r["mn_Id"].ToString());
                mn_id = r["mn_Id"].ToString();


                //if (mn_id == "")
                //{
                //    MessageBox.Show("mn_id가 비었습니다.");
                //    return;
                //}

                DataSet MongolianId = new DataSet();
                {

                    string sql = "SELECT * FROM mongolian where mn_ID = '" + mn_id + "'";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(MongolianId, "kr_mn");
                }
                foreach (DataRow r1 in MongolianId.Tables[0].Rows)
                {

                    ListViewItem lvi1 = new ListViewItem(r1["mn_Id"].ToString());

                    lvi1.SubItems.Add(r1["mn_Name"].ToString());
                    lvi1.SubItems.Add(r1["mn_Pos"].ToString());
                    lvi1.SubItems.Add(r1["mn_SenseTag"].ToString());


                    lvMongolian.Items.Add(lvi1);
                    txtExplainMn.Text = r1["mn_Explain"].ToString();
                    txtExampleMn.Text = r1["mn_Example"].ToString();


                }
            }
            DataSet krExplain = new DataSet();
            {
                string sql = "SELECT * FROM uwin where KeyID = " + koreankey;
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(krExplain, "uwin");
            }
            foreach (DataRow r in krExplain.Tables[0].Rows)
            {
                txtExplainKr.Text = r["Explain1"].ToString();
                txtExampleKr.Text = r["Bigo"].ToString();
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lvMongolian.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택되어야 삭제할 수 있습니다. ");
                return;
            }
            //  DataSet deleteResult = new DataSet();
            //   int mongoliankey = Convert.ToInt32(lvMongolian.SelectedItems[0].Text);
            delete deleteword = new delete(this);
            deleteword.ShowDialog();



        }
        public void DeleteWord()
        {
            try
            {
                MySqlConnection conn = lo.getConn();
                if (conn == null)
                {
                    return;
                }
                string sql = "delete from krmndic.mongolian where mn_ID = '" + lvMongolian.SelectedItems[0].Text + "';";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                // adpt.Fill(deleteResult, "mongolian");
                MySqlCommand cmdDataBase = new MySqlCommand(sql, conn);
                MySqlDataReader myReader;
                conn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data Deleted");
                //lvMongolian.Clear();
                lvMongolian.Items.Clear();
                txtExplainMn.Text = "";
                txtExampleMn.Text = "";
                while (myReader.Read())
                { }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvMongolian.Items.Count == 0)
            {
                MessageBox.Show("선택되어야 수정할 수 있습니다.");
                return;
            }
            
            Edit editword = new Edit(this);
            editword.ShowDialog();
        }

        public int Pass
        {
            get
            { return  Convert.ToInt32(lvMongolian.SelectedItems[0].Text); }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
			if (lvKorean.SelectedItems.Count == 0)
			{
				MessageBox.Show("한국어 단어를 먼저 선택하세요!");
				return;
			}
            AddWord1 Add1 = new AddWord1(this);
            Add1.ShowDialog();

        }
        
    }
}
