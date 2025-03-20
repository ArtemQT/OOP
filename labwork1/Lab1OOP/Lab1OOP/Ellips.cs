using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
    public class Ellipse : Figure
    {
        protected int Width {  get; set; }
        protected int Height { get; set; }

        public Ellipse(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X, Y, Width, Height);
            g.FillEllipse(Brushes.Coral, X, Y, Width, Height);
        }

        public override void Message()
        {
            MessageBox.Show("Вы выбрали эллипс", "Выбранная фигура");
        }

        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Эллипс");
        }
    }
}
