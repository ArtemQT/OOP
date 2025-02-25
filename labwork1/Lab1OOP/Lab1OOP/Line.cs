using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
    public class Line : Figure
    {
        public override void Draw(Graphics g, Point p)
        {
            g.DrawLine(Pens.Black, p.X, p.Y, p.X + 100, p.Y);
        }

        public override void Message()
        {
            MessageBox.Show("Вы выбрали линию", "Выбранная фигура");
        }
    }
}
