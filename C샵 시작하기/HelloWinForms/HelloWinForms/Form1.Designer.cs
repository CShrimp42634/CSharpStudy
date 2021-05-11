namespace HelloWinForms
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
            this.BtnCall = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnCall
            // 
            this.BtnCall.Location = new System.Drawing.Point(381, 62);
            this.BtnCall.Name = "BtnCall";
            this.BtnCall.Size = new System.Drawing.Size(75, 23);
            this.BtnCall.TabIndex = 0;
            this.BtnCall.Text = "꾸욱";
            this.BtnCall.UseVisualStyleBackColor = true;
            this.BtnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(255, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 12);
            this.label.TabIndex = 3;
            this.label.Text = "label1";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(104, 64);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 21);
            this.textBox.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chAuthor,
            this.chDescription,
            this.chPublisher,
            this.chPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 305);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chTitle
            // 
            this.chTitle.Text = "책제목";
            this.chTitle.Width = 104;
            // 
            // chAuthor
            // 
            this.chAuthor.Text = "저자";
            this.chAuthor.Width = 98;
            // 
            // chDescription
            // 
            this.chDescription.Text = "줄거리";
            this.chDescription.Width = 334;
            // 
            // chPublisher
            // 
            this.chPublisher.Text = "출판사";
            this.chPublisher.Width = 88;
            // 
            // chPrice
            // 
            this.chPrice.Text = "가격";
            this.chPrice.Width = 111;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.BtnCall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCall;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chAuthor;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chPublisher;
        private System.Windows.Forms.ColumnHeader chPrice;
    }
}

