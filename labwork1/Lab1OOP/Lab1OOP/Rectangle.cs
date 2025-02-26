using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
    public class Rectangle : Parallelogram
    {
      
        public override void Draw(Graphics g, Point p)
        {
            g.DrawRectangle(Pens.Black, p.X, p.Y, 120, 50);
            g.FillRectangle(Brushes.BlueViolet, p.X, p.Y, 120, 50);
        }
        public override void Message()
        {
            MessageBox.Show("Вы выбрали прямоугольник", "Выбранная фигура");
        }

        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Прямоугольник");
        }
    }
}
