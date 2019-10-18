using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class Form1 : Form
    {
        bool click = false;

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Size = new Size(500, 500);//設定視窗大小
            this.CenterToScreen();//視窗至中
            this.FormBorderStyle = FormBorderStyle.FixedSingle;//視窗外框
            picturebox.BorderStyle = BorderStyle.Fixed3D;//畫面框
            this.Text = "homework2";//視窗左上標題列文字
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (click)
            {
                Graphics g = e.Graphics;//畫布
                Pen pen = new Pen(Color.Brown,10);//畫筆
                float length = Convert.ToSingle(tb1.Text);
                double anglevar = Convert.ToDouble(nud3.Value);
                int depth = Convert.ToInt32(nud1.Value);//level
                float xo = (  picturebox.Width / 2) - 2;
                float yo = picturebox.Height - Convert.ToSingle(5.4);
                paintFractalTree(pen, xo, yo, depth, 90, length, anglevar, g);
                pen.Dispose();
                click = false;
            }
        }

        private void paintFractalTree(Pen pen, float xo, float yo, int depth, double angle, float length,  double anglevar, Graphics line)
        {
            if (depth > -1)
            {   
                float yf = yo - (sin(degreeToRadian(angle)) * length * depth);
                float xf = xo - (cos(degreeToRadian(angle)) * length * depth);
                line.DrawLine(pen, xo, yo, xf, yf);
                paintFractalTree(pen, xf, yf, depth - 1, angle + anglevar, length, anglevar, line);
                paintFractalTree(pen, xf, yf, depth - 1, angle - anglevar, length, anglevar, line);
            }
        }

        private float cos(double angle)
        {
            return (float)Math.Cos(angle);
        }

        private float sin(double angle)
        {
            return (float)Math.Sin(angle);
        }

        private double degreeToRadian(double angle)
        {
            return (Math.PI * angle) / 180;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !e.KeyChar.Equals(','))
            {
                e.Handled = true;
            }
        }

        private void drawbt_Click(object sender, EventArgs e)
        { //按下 Draw button 用 click去觸發 pictureBox_Paint 裡的 if (畫圖) 


            click = true; 
            picturebox.Refresh();
        }
    }
}
