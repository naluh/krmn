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
    public partial class delete : Form
    {
        Form1 fm1;
        public delete(Form1 fm1)
        {
            InitializeComponent();
            this.fm1 = fm1;
        }

        private void yesBTN_Click(object sender, EventArgs e)
        {
            if (this.pwTextBox.Text == "0126")
            {
                fm1.DeleteWord();
                this.Close();
            }
            else
                MessageBox.Show("비밀번호 일치하지 않습니다!");
        }

        private void noBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
