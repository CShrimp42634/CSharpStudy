namespace _11.Struct_Class
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboxSun = new System.Windows.Forms.PictureBox();
            this.pboxMoon = new System.Windows.Forms.PictureBox();
            this.pboxNone = new System.Windows.Forms.PictureBox();
            this.pboxStar = new System.Windows.Forms.PictureBox();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.lboxResult1 = new System.Windows.Forms.ListBox();
            this.lboxResult2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "-Player는 한번 씩 돌아가면서 그림을 선택 합니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "- 각 5회 진행 후 하늘,검정,살색의 숫자의 합이 가장 높은 사람이 승리 합니다.";
            // 
            // pboxSun
            // 
            this.pboxSun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pboxSun.Location = new System.Drawing.Point(16, 98);
            this.pboxSun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxSun.Name = "pboxSun";
            this.pboxSun.Size = new System.Drawing.Size(123, 190);
            this.pboxSun.TabIndex = 2;
            this.pboxSun.TabStop = false;
            this.pboxSun.Click += new System.EventHandler(this.pboxSun_Click);
            // 
            // pboxMoon
            // 
            this.pboxMoon.BackColor = System.Drawing.Color.Black;
            this.pboxMoon.Location = new System.Drawing.Point(167, 98);
            this.pboxMoon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxMoon.Name = "pboxMoon";
            this.pboxMoon.Size = new System.Drawing.Size(123, 190);
            this.pboxMoon.TabIndex = 3;
            this.pboxMoon.TabStop = false;
            this.pboxMoon.Click += new System.EventHandler(this.pboxMoon_Click);
            // 
            // pboxNone
            // 
            this.pboxNone.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pboxNone.Location = new System.Drawing.Point(470, 98);
            this.pboxNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxNone.Name = "pboxNone";
            this.pboxNone.Size = new System.Drawing.Size(123, 190);
            this.pboxNone.TabIndex = 4;
            this.pboxNone.TabStop = false;
            this.pboxNone.Click += new System.EventHandler(this.pboxNone_Click);
            // 
            // pboxStar
            // 
            this.pboxStar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pboxStar.Location = new System.Drawing.Point(318, 98);
            this.pboxStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxStar.Name = "pboxStar";
            this.pboxStar.Size = new System.Drawing.Size(123, 190);
            this.pboxStar.TabIndex = 5;
            this.pboxStar.TabStop = false;
            this.pboxStar.Click += new System.EventHandler(this.pboxStar_Click);
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(14, 320);
            this.rdoPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(77, 19);
            this.rdoPlayer1.TabIndex = 6;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "Player1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(353, 320);
            this.rdoPlayer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(77, 19);
            this.rdoPlayer2.TabIndex = 7;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "Player2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            // 
            // lboxResult1
            // 
            this.lboxResult1.FormattingEnabled = true;
            this.lboxResult1.ItemHeight = 15;
            this.lboxResult1.Location = new System.Drawing.Point(14, 348);
            this.lboxResult1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxResult1.Name = "lboxResult1";
            this.lboxResult1.Size = new System.Drawing.Size(294, 109);
            this.lboxResult1.TabIndex = 8;
            this.lboxResult1.UseTabStops = false;
            // 
            // lboxResult2
            // 
            this.lboxResult2.FormattingEnabled = true;
            this.lboxResult2.ItemHeight = 15;
            this.lboxResult2.Location = new System.Drawing.Point(353, 348);
            this.lboxResult2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxResult2.Name = "lboxResult2";
            this.lboxResult2.Size = new System.Drawing.Size(255, 109);
            this.lboxResult2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 466);
            this.Controls.Add(this.lboxResult2);
            this.Controls.Add(this.lboxResult1);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.rdoPlayer1);
            this.Controls.Add(this.pboxStar);
            this.Controls.Add(this.pboxNone);
            this.Controls.Add(this.pboxMoon);
            this.Controls.Add(this.pboxSun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboxSun;
        private System.Windows.Forms.PictureBox pboxMoon;
        private System.Windows.Forms.PictureBox pboxNone;
        private System.Windows.Forms.PictureBox pboxStar;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.ListBox lboxResult1;
        private System.Windows.Forms.ListBox lboxResult2;
    }
}

