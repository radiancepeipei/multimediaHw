﻿namespace point
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PositionLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionLebel
            // 
            this.PositionLebel.AutoSize = true;
            this.PositionLebel.Location = new System.Drawing.Point(12, 429);
            this.PositionLebel.Name = "PositionLebel";
            this.PositionLebel.Size = new System.Drawing.Size(7, 15);
            this.PositionLebel.TabIndex = 0;
            this.PositionLebel.Text = "\r\n";
            this.PositionLebel.Click += new System.EventHandler(this.PositionLebel_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "+";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.PositionLebel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLebel;
    }
}

