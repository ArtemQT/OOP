using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
    public class Circle : Ellipse
    {
        public override void Draw(Graphics g, Point p)
        {
            g.DrawEllipse(Pens.Black, p.X, p.Y, 50, 50);
            g.FillEllipse(Brushes.DeepPink, p.X, p.Y, 50, 50);
        }

        public override void Message()
        {
            MessageBox.Show("Вы выбрали круг", "Выбранная фигура");
        }

        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Круг");
        }
    }
}
