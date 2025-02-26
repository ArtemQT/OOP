using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
        public class Square : Rectangle
        {
            public override void Draw(Graphics g, Point p)
            {
                g.DrawRectangle(Pens.Black, p.X, p.Y, 50, 50);
                g.FillRectangle(Brushes.BurlyWood, p.X, p.Y, 50, 50);
            }
            public override void Message()
            {
                MessageBox.Show("Вы выбрали Квадрат", "Выбранная фигура");
            }

            public override void AddToListBox(ListBox listBox)
            {
                listBox.Items.Add("Квадрат");
            }
    }
}
