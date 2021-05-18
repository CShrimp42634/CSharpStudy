namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblContain = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.lblTolower = new System.Windows.Forms.Label();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.lblSplit3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(38, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(106, 12);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Sample,Test,Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Split";
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(133, 97);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(11, 12);
            this.lblContain.TabIndex = 12;
            this.lblContain.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "Substring";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "ToLower";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(241, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 12);
            this.label18.TabIndex = 25;
            this.label18.Text = "ToUPPer";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(241, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 12);
            this.label19.TabIndex = 26;
            this.label19.Text = "Trim";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(133, 152);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(11, 12);
            this.lblEquals.TabIndex = 27;
            this.lblEquals.Text = "-";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(133, 201);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(11, 12);
            this.lblLength.TabIndex = 28;
            this.lblLength.Text = "-";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(133, 248);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(11, 12);
            this.lblReplace.TabIndex = 29;
            this.lblReplace.Text = "-";
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(133, 297);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(11, 12);
            this.lblSplit.TabIndex = 30;
            this.lblSplit.Text = "-";
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(335, 97);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(11, 12);
            this.lblSubstring.TabIndex = 31;
            this.lblSubstring.Text = "-";
            // 
            // lblTolower
            // 
            this.lblTolower.AutoSize = true;
            this.lblTolower.Location = new System.Drawing.Point(335, 152);
            this.lblTolower.Name = "lblTolower";
            this.lblTolower.Size = new System.Drawing.Size(11, 12);
            this.lblTolower.TabIndex = 32;
            this.lblTolower.Text = "-";
            // 
            // lblToUpper
            // 
            this.lblToUpper.AutoSize = true;
            this.lblToUpper.Location = new System.Drawing.Point(335, 201);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(11, 12);
            this.lblToUpper.TabIndex = 33;
            this.lblToUpper.Text = "-";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(335, 248);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(11, 12);
            this.lblTrim.TabIndex = 34;
            this.lblTrim.Text = "-";
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.Location = new System.Drawing.Point(133, 341);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(11, 12);
            this.lblSplit2.TabIndex = 35;
            this.lblSplit2.Text = "-";
            // 
            // lblSplit3
            // 
            this.lblSplit3.AutoSize = true;
            this.lblSplit3.Location = new System.Drawing.Point(133, 380);
            this.lblSplit3.Name = "lblSplit3";
            this.lblSplit3.Size = new System.Drawing.Size(11, 12);
            this.lblSplit3.TabIndex = 36;
            this.lblSplit3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 477);
            this.Controls.Add(this.lblSplit3);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.lblTolower);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblContain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.Label lblTolower;
        private System.Windows.Forms.Label lblToUpper;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.Label lblSplit3;
    }
}

