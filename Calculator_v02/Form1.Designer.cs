﻿
namespace Calculator_v02
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.sumbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(157, 203);
            this.num1.Margin = new System.Windows.Forms.Padding(5);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(177, 42);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(383, 203);
            this.num2.Margin = new System.Windows.Forms.Padding(5);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(177, 42);
            this.num2.TabIndex = 1;
            // 
            // sumbtn
            // 
            this.sumbtn.Location = new System.Drawing.Point(319, 307);
            this.sumbtn.Margin = new System.Windows.Forms.Padding(5);
            this.sumbtn.Name = "sumbtn";
            this.sumbtn.Size = new System.Drawing.Size(135, 125);
            this.sumbtn.TabIndex = 2;
            this.sumbtn.Text = "+";
            this.sumbtn.UseVisualStyleBackColor = true;
            this.sumbtn.Click += new System.EventHandler(this.sumbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 307);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 125);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(689, 203);
            this.result.Margin = new System.Windows.Forms.Padding(5);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(177, 42);
            this.result.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sumbtn);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button sumbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
    }
}

