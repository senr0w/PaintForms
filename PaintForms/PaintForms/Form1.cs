using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoint()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints(){
                return points;
            }
        }
        private bool DrawMouse=false;
        private ArrayPoints arrayPoints=new ArrayPoints(2);
        Bitmap map=new Bitmap(100,100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3);
        private void SetSize()
        {
            Rectangle rectangle=Screen.PrimaryScreen.Bounds;
            map=new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void Holst_MouseDown(object sender, MouseEventArgs e)
            {
             DrawMouse= true;
            Refresh();
        }
         private void Holst_MouseUp(object sender, MouseEventArgs e)
            {
            DrawMouse = false;
            arrayPoints.ResetPoint();
            Refresh();
        }
        private void Holst_MouseMove(object sender, MouseEventArgs e)
        {
            if (!DrawMouse) { return; }
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen,arrayPoints.GetPoints());
                Circle.Image = map;
                arrayPoints.SetPoint(e.X,e.Y);
            }
            Refresh();
        }
    
        private void Color_Click(object sender, EventArgs e)
        {
            pen.Color=((Button)sender).BackColor;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Circle.BackColor);
            Circle.Image = map;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                if (Circle.Image == null)
                {
                    Circle.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void Width_ValueChanged(object sender, EventArgs e)
        {
            pen.Width=Width.Value;
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                pen.Color=colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
