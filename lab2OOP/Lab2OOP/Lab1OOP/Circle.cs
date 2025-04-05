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
        protected int Radius { get; set; }
        public Circle(int x, int y, int width, int height) : base(x, y, width, height) { }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X, Y, Width, Height);
            g.FillEllipse(Brushes.DeepPink, X, Y, Width, Height);
        }

        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Круг");
        }
            
    }
}
