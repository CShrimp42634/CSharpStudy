﻿
namespace _15_part
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
            this.lboxltem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxltem = new System.Windows.Forms.ComboBox();
            this.cboxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCout = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxErrorMsg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCout)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxltem
            // 
            this.lboxltem.FormattingEnabled = true;
            this.lboxltem.ItemHeight = 12;
            this.lboxltem.Location = new System.Drawing.Point(1, 12);
            this.lboxltem.Name = "lboxltem";
            this.lboxltem.Size = new System.Drawing.Size(352, 268);
            this.lboxltem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "물건";
            // 
            // cboxltem
            // 
            this.cboxltem.FormattingEnabled = true;
            this.cboxltem.Location = new System.Drawing.Point(382, 27);
            this.cboxltem.Name = "cboxltem";
            this.cboxltem.Size = new System.Drawing.Size(121, 20);
            this.cboxltem.TabIndex = 2;
            // 
            // cboxRate
            // 
            this.cboxRate.FormattingEnabled = true;
            this.cboxRate.Location = new System.Drawing.Point(382, 103);
            this.cboxRate.Name = "cboxRate";
            this.cboxRate.Size = new System.Drawing.Size(121, 20);
            this.cboxRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "할인율 (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "개수";
            // 
            // numCout
            // 
            this.numCout.Location = new System.Drawing.Point(382, 175);
            this.numCout.Name = "numCout";
            this.numCout.Size = new System.Drawing.Size(120, 21);
            this.numCout.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(382, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(1, 298);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(352, 21);
            this.tboxResult.TabIndex = 8;
            // 
            // tboxErrorMsg
            // 
            this.tboxErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.tboxErrorMsg.Location = new System.Drawing.Point(1, 341);
            this.tboxErrorMsg.Name = "tboxErrorMsg";
            this.tboxErrorMsg.Size = new System.Drawing.Size(501, 21);
            this.tboxErrorMsg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 408);
            this.Controls.Add(this.tboxErrorMsg);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxltem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxltem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxltem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxltem;
        private System.Windows.Forms.ComboBox cboxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxErrorMsg;
    }
}

