namespace KoreanMongolianDictionary
{
    partial class delete
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
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.noBTN = new System.Windows.Forms.Button();
            this.yesBTN = new System.Windows.Forms.Button();
            this.lblDeleteWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 10F);
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "다음 단어를 삭제하시겠습니까?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 12F);
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "비밀번호";
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(23, 145);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.PasswordChar = '*';
            this.pwTextBox.Size = new System.Drawing.Size(202, 21);
            this.pwTextBox.TabIndex = 8;
            // 
            // noBTN
            // 
            this.noBTN.Location = new System.Drawing.Point(23, 172);
            this.noBTN.Name = "noBTN";
            this.noBTN.Size = new System.Drawing.Size(98, 42);
            this.noBTN.TabIndex = 9;
            this.noBTN.Text = "취소";
            this.noBTN.UseVisualStyleBackColor = true;
            // 
            // yesBTN
            // 
            this.yesBTN.Location = new System.Drawing.Point(127, 172);
            this.yesBTN.Name = "yesBTN";
            this.yesBTN.Size = new System.Drawing.Size(98, 42);
            this.yesBTN.TabIndex = 10;
            this.yesBTN.Text = "확인";
            this.yesBTN.UseVisualStyleBackColor = true;
            // 
            // lblDeleteWord
            // 
            this.lblDeleteWord.AutoSize = true;
            this.lblDeleteWord.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblDeleteWord.Location = new System.Drawing.Point(19, 62);
            this.lblDeleteWord.Name = "lblDeleteWord";
            this.lblDeleteWord.Size = new System.Drawing.Size(0, 19);
            this.lblDeleteWord.TabIndex = 11;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 232);
            this.Controls.Add(this.lblDeleteWord);
            this.Controls.Add(this.yesBTN);
            this.Controls.Add(this.noBTN);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "delete";
            this.Text = "삭제 확인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Button noBTN;
        private System.Windows.Forms.Button yesBTN;
        private System.Windows.Forms.Label lblDeleteWord;
    }
}