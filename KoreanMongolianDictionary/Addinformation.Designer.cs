namespace KoreanMongolianDictionary
{
    partial class Addinformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMnId = new System.Windows.Forms.TextBox();
            this.txtMnName = new System.Windows.Forms.TextBox();
            this.txtMnSenseTag = new System.Windows.Forms.TextBox();
            this.txtMnPos = new System.Windows.Forms.TextBox();
            this.txtMnExplain = new System.Windows.Forms.TextBox();
            this.txtMnExample = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "mn_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "mn_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "mn_SenseTag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "mn_Pos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "mn_Explain";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "mn_Example";
            // 
            // txtMnId
            // 
            this.txtMnId.Location = new System.Drawing.Point(146, 49);
            this.txtMnId.Name = "txtMnId";
            this.txtMnId.Size = new System.Drawing.Size(154, 21);
            this.txtMnId.TabIndex = 7;
            // 
            // txtMnName
            // 
            this.txtMnName.Location = new System.Drawing.Point(146, 88);
            this.txtMnName.Name = "txtMnName";
            this.txtMnName.Size = new System.Drawing.Size(154, 21);
            this.txtMnName.TabIndex = 8;
            // 
            // txtMnSenseTag
            // 
            this.txtMnSenseTag.Location = new System.Drawing.Point(146, 132);
            this.txtMnSenseTag.Name = "txtMnSenseTag";
            this.txtMnSenseTag.Size = new System.Drawing.Size(154, 21);
            this.txtMnSenseTag.TabIndex = 9;
            // 
            // txtMnPos
            // 
            this.txtMnPos.Location = new System.Drawing.Point(146, 174);
            this.txtMnPos.Name = "txtMnPos";
            this.txtMnPos.Size = new System.Drawing.Size(154, 21);
            this.txtMnPos.TabIndex = 10;
            // 
            // txtMnExplain
            // 
            this.txtMnExplain.Location = new System.Drawing.Point(146, 213);
            this.txtMnExplain.Name = "txtMnExplain";
            this.txtMnExplain.Size = new System.Drawing.Size(154, 21);
            this.txtMnExplain.TabIndex = 11;
            // 
            // txtMnExample
            // 
            this.txtMnExample.Location = new System.Drawing.Point(146, 248);
            this.txtMnExample.Name = "txtMnExample";
            this.txtMnExample.Size = new System.Drawing.Size(154, 21);
            this.txtMnExample.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(187, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "최소";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Addinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 376);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMnExample);
            this.Controls.Add(this.txtMnExplain);
            this.Controls.Add(this.txtMnPos);
            this.Controls.Add(this.txtMnSenseTag);
            this.Controls.Add(this.txtMnName);
            this.Controls.Add(this.txtMnId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addinformation";
            this.Text = "Addinformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMnId;
        private System.Windows.Forms.TextBox txtMnName;
        private System.Windows.Forms.TextBox txtMnSenseTag;
        private System.Windows.Forms.TextBox txtMnPos;
        private System.Windows.Forms.TextBox txtMnExplain;
        private System.Windows.Forms.TextBox txtMnExample;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}