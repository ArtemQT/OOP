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
        public override void Draw(Graphics g, Point p)
        {


            int width = 100; 
            int height = 50; 
            int offset = 20; 

            Point[] PointsForPolygon = new Point[]
            {
                new Point(p.X, p.Y),
                new Point(p.X + width, p.Y),
                new Point(p.X + width - offset, p.Y + height),
                new Point(p.X - offset, p.Y + height)
            };

            g.DrawPolygon(Pens.Black, PointsForPolygon);
            g.FillPolygon(Brushes.Aquamarine, PointsForPolygon);
        }

        public override void Message()
        {
            MessageBox.Show("Вы выбрали паралелограмм", "Выбранная фигура");
        }

        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Паралелограмм");
        }
    }
}
