namespace KoreanMongolianDictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvKorean = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMongolian = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtExampleMn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExampleKr = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvLastSearch = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtExplainKr = new System.Windows.Forms.TextBox();
            this.txtExplainMn = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Gulim", 12F);
            this.btnSearch.Location = new System.Drawing.Point(298, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 67);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Gulim", 12F);
            this.btnEdit.Location = new System.Drawing.Point(848, 99);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Gulim", 18F);
            this.txtSearch.Location = new System.Drawing.Point(36, 26);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 67);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvKorean, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvMongolian, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtExampleMn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtExampleKr, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtExplainKr, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtExplainMn, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 151);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.28214F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.717869F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 485);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Жишээ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(545, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "예문";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Тайлбар";
            // 
            // lvKorean
            // 
            this.lvKorean.AutoArrange = false;
            this.lvKorean.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8});
            this.lvKorean.FullRowSelect = true;
            this.lvKorean.GridLines = true;
            this.lvKorean.Location = new System.Drawing.Point(3, 3);
            this.lvKorean.Name = "lvKorean";
            this.lvKorean.Size = new System.Drawing.Size(545, 267);
            this.lvKorean.TabIndex = 0;
            this.lvKorean.UseCompatibleStateImageBehavior = false;
            this.lvKorean.View = System.Windows.Forms.View.Details;
            this.lvKorean.SelectedIndexChanged += new System.EventHandler(this.lvKorean_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KeyID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "POS";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 126;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SenseTag";
            this.columnHeader8.Width = 121;
            // 
            // lvMongolian
            // 
            this.lvMongolian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9});
            this.lvMongolian.FullRowSelect = true;
            this.lvMongolian.GridLines = true;
            this.lvMongolian.Location = new System.Drawing.Point(554, 3);
            this.lvMongolian.Name = "lvMongolian";
            this.lvMongolian.Size = new System.Drawing.Size(545, 267);
            this.lvMongolian.TabIndex = 1;
            this.lvMongolian.UseCompatibleStateImageBehavior = false;
            this.lvMongolian.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KeyID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "POS";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SenseTag";
            this.columnHeader9.Width = 128;
            // 
            // txtExampleMn
            // 
            this.txtExampleMn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExampleMn.Location = new System.Drawing.Point(554, 412);
            this.txtExampleMn.Multiline = true;
            this.txtExampleMn.Name = "txtExampleMn";
            this.txtExampleMn.ReadOnly = true;
            this.txtExampleMn.Size = new System.Drawing.Size(545, 70);
            this.txtExampleMn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "뜻";
            // 
            // txtExampleKr
            // 
            this.txtExampleKr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExampleKr.Location = new System.Drawing.Point(3, 412);
            this.txtExampleKr.Multiline = true;
            this.txtExampleKr.Name = "txtExampleKr";
            this.txtExampleKr.ReadOnly = true;
            this.txtExampleKr.Size = new System.Drawing.Size(545, 70);
            this.txtExampleKr.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Gulim", 12F);
            this.btnDelete.Location = new System.Drawing.Point(1012, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 46);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Gulim", 12F);
            this.btnAdd.Location = new System.Drawing.Point(930, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 12F);
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "한국어";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 12F);
            this.label6.Location = new System.Drawing.Point(550, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "몽골어";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 18;
            // 
            // lvLastSearch
            // 
            this.lvLastSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.lvLastSearch.GridLines = true;
            this.lvLastSearch.Location = new System.Drawing.Point(463, 12);
            this.lvLastSearch.Name = "lvLastSearch";
            this.lvLastSearch.Size = new System.Drawing.Size(624, 81);
            this.lvLastSearch.TabIndex = 19;
            this.lvLastSearch.UseCompatibleStateImageBehavior = false;
            this.lvLastSearch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "최근 검색한 단어";
            this.columnHeader7.Width = 160;
            // 
            // txtExplainKr
            // 
            this.txtExplainKr.Location = new System.Drawing.Point(3, 305);
            this.txtExplainKr.Multiline = true;
            this.txtExplainKr.Name = "txtExplainKr";
            this.txtExplainKr.Size = new System.Drawing.Size(545, 71);
            this.txtExplainKr.TabIndex = 21;
            // 
            // txtExplainMn
            // 
            this.txtExplainMn.Location = new System.Drawing.Point(554, 305);
            this.txtExplainMn.Multiline = true;
            this.txtExplainMn.Name = "txtExplainMn";
            this.txtExplainMn.Size = new System.Drawing.Size(545, 71);
            this.txtExplainMn.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 639);
            this.Controls.Add(this.lvLastSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "한국어 몽골어 사전 관리 도구";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvKorean;
        private System.Windows.Forms.ListView lvMongolian;
        private System.Windows.Forms.TextBox txtExampleKr;
        private System.Windows.Forms.TextBox txtExampleMn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvLastSearch;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtExplainKr;
        private System.Windows.Forms.TextBox txtExplainMn;

    }
}

