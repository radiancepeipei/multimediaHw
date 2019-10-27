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
            this.Size = new Size(650, 500);//設定視窗大小
            this.CenterToScreen();//視窗至中
            this.FormBorderStyle = FormBorderStyle.FixedSingle;//視窗外框
            picturebox.BorderStyle = BorderStyle.Fixed3D;//畫面框
            this.picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            this.picturebox.Height = 400;
            this.picturebox.Width = 500;
            this.Text = "homework2";//視窗左上標題列文字
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (click)
            {
                Graphics g = e.Graphics;//畫布
                Pen pen = new Pen(Color.Brown,10);//畫筆             
                float length = Convert.ToSingle(100);
                double anglevar = Convert.ToDouble(30);
                float p = Convert.ToSingle(0.75);
                int level = Convert.ToInt32(nud1.Value);//level
                float xo = (picturebox.Width / 2);
                float yo = picturebox.Height ;
                float root = level;
                paintFractalTree(pen, xo, yo, level, 90, length, p, anglevar, g, pen.Width,root);
                pen.Dispose();
                click = false;
            }
        }



        private void paintFractalTree(Pen pen, float xo, float yo, int level, double angle, float length, float p,  double anglevar, Graphics line, float penwidth,float root)
        {
            pen.Width = penwidth;
            if (length < 40)
                {
                    pen.Color = Color.LightPink;//當樹枝長度<40px 畫筆換成淺粉色
                }
            else {
                    pen.Color = Color.Brown;  //其他長度換回咖啡色
                }
            if (level > 0)
            {
               
                    float yf = yo - (sin(degreeToRadian(angle)) * length);
                    float xf = xo - (cos(degreeToRadian(angle)) * length);
                    line.DrawLine(pen, xo, yo, xf, yf);
                    length = length * p;
                    penwidth--;
                    level--;
                    paintFractalTree(pen, xf, yf, level, angle + anglevar, length, p, anglevar, line, penwidth,root);//長右枝
                    paintFractalTree(pen, xf, yf, level, angle - anglevar, length, p, anglevar, line, penwidth,root);//長左枝
        
            }

        }

        private float branch(float xo, float yo, float xf, float yf) {
            double len = Math.Pow((Math.Pow(Convert.ToDouble(xf - xo), 2) + Math.Pow(Convert.ToDouble(yf - yo), 2)),0.5);
            return Convert.ToSingle(len);
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

    

        private void nud1_ValueChanged(object sender, EventArgs e)
        {

            click = true;
            picturebox.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
