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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int ClickCount = 0;
        int MaxClickCount = 4;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "";
            ClickCount++;
            if (ClickCount > MaxClickCount)
            {
                message = string.Format("已經clickt超過{0}次", MaxClickCount);

            }
            else {
                message = string.Format("position coordination:X:{0}  Y:{1} ,被Click{2}次。",e.X,e.Y,ClickCount);
                Graphics graphics = this.CreateGraphics();
                Pen pointpen = new Pen(Color.Black,1);
                graphics.DrawRectangle(pointpen,e.X,e.Y,5,5);


            }

           
            PositionLebel.Text = message;


        }

        private void Point_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;//建立畫布
            Pen pen = new Pen(Color.Black, 1);//建立畫筆物件
            Point p1 = new Point(260, 140);
            Point p2 = new Point(290, 40);
            Point p3 = new Point(320, 100);
            Point p4 = new Point(350, 20);
           
            canvas.DrawBezier(pen, p1, p2, p3, p4); //兩點座標成線
            //canvas.Dispose();//把畫布物件從記憶體中刪除
        }







        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;//建立畫布
            Pen pen = new Pen(Color.Black,1);//建立畫筆物件
            Point p1 = new Point(260, 140);
            Point p2 = new Point(290,40);
            Point p3 = new Point(320, 100);
            Point p4 = new Point(350, 20);
            canvas.FillRectangle(Brushes.Red, 100, 100, 1, 1);  //used 1,1 for a pixel only
            canvas.DrawBezier(pen,p1,p2,p3,p4); //兩點座標成線
            //canvas.Dispose();//把畫布物件從記憶體中刪除
        }
        
        private void PositionLebel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
