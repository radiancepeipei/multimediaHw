namespace FractalTree
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.drawbt = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level :";
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(215, 374);
            this.nud1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(53, 25);
            this.nud1.TabIndex = 1;
            this.nud1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud1.ValueChanged += new System.EventHandler(this.nud1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branch length:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(352, 414);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(52, 25);
            this.tb1.TabIndex = 5;
            this.tb1.Text = "3";
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Angle variation:";
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(429, 375);
            this.nud3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(53, 25);
            this.nud3.TabIndex = 7;
            this.nud3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // drawbt
            // 
            this.drawbt.Location = new System.Drawing.Point(271, 460);
            this.drawbt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drawbt.Name = "drawbt";
            this.drawbt.Size = new System.Drawing.Size(100, 25);
            this.drawbt.TabIndex = 8;
            this.drawbt.Text = "Draw";
            this.drawbt.UseVisualStyleBackColor = true;
            this.drawbt.Click += new System.EventHandler(this.drawbt_Click);
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(113, 28);
            this.picturebox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(415, 323);
            this.picturebox.TabIndex = 10;
            this.picturebox.TabStop = false;
            this.picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 532);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.drawbt);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.Button drawbt;
        private System.Windows.Forms.PictureBox picturebox;
    }
}

