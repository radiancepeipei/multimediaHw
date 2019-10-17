using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Pen pointpen = new Pen(Color.Black, 1);
        private int NextPoint = 0;
        private Point[] points = new Point[4];
        private Point[] bezier = new Point[4];
        private Point p1 = new Point(0, 100);
        private Point p2 = new Point(100, 200);
        private Point p3 = new Point(100, 0);
        private Point p4 = new Point(200, 100);

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loading 預設 Point 資訊
           /* points[0].X = 0;
            points[0].Y = 100;
            points[1].X = 100;
            points[1].Y = 200;
            points[2].X = 100;
            points[2].Y = 0;
            points[3].X = 200;
            points[3].Y = 100;*/
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics canvas = this.CreateGraphics();
           
            points[NextPoint % 4].X = e.X;
            points[NextPoint % 4].Y = e.Y;
            NextPoint += 1;

            if (NextPoint % 4 == 0)
            {
                p1 = points[0];
                p2 = points[1];
                p3 = points[2];
                p4 = points[3];
                canvas.Clear(Color.White);             //清空
            }
            
            // 畫圖
            for (int i = 0; i < 4; i++)
            {
                canvas.DrawRectangle(pointpen, points[i].X, points[i].Y, 5, 5);
            }
            canvas.DrawBezier(pointpen, p1, p2, p3, p4);

            // 各點資訊
            string message = "";
            message = string.Format("position coordination:X:{0}  Y:{1} ,被Click {2}次。", e.X, e.Y, NextPoint);
            PositionLebel.Text = message; 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;//建立畫布
            canvas.Clear(Color.White);//畫布換成白色
            Pen pointpen = new Pen(Color.Black, 1);//建立畫筆物件
            canvas.DrawRectangle(pointpen, p1.X, p1.Y, 5, 5);
            canvas.DrawRectangle(pointpen, p2.X, p2.Y, 5, 5);
            canvas.DrawRectangle(pointpen, p3.X, p3.Y, 5, 5);
            canvas.DrawRectangle(pointpen, p4.X, p4.Y, 5, 5);
            canvas.DrawBezier(pointpen, p1, p2, p3, p4); //畫 Bezier curve
            canvas.Dispose();//把畫布物件從記憶體中刪除
        }

        private void Temp_Bezier(Pen pen, Point p1, Point p2, Point p3, Point p4)
        {

        }

        private void PositionLebel_Click(object sender, EventArgs e)
        {

        }     
    }
}
