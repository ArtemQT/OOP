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

        private int X2 { get; set; }
        private int Y2 { get; set; }

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            X2 = x2;   
            Y2 = y2;  
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, X, Y, X2, Y2);
        }

        public override void AddToListBox(ListBox listBox)
        {
            listBox.Items.Add("Линия");
        }
    }
}
