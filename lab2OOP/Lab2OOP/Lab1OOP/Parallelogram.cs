using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1OOP
{
    public class Parallelogram : Figure
    {
        protected int Width {  get; set; }
        protected int Height { get; set; }

        public Parallelogram(int x, int y,int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            int offset = 20; 

            Point[] PointsForPolygon = new Point[]
            {
                new Point(X, Y),
                new Point(X + Width, Y),
                new Point(X + Width - offset, Y + Height),
                new Point(X - offset, Y + Height)
            };

            g.DrawPolygon(Pens.Black, PointsForPolygon);
            g.FillPolygon(Brushes.Aquamarine, PointsForPolygon);
        }
        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Паралелограмм");
        }
    }
}
