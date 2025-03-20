using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lab1OOP
{
    public abstract class Figure
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Figure() { }
        public abstract void Draw(Graphics g);
        public abstract void Message();
        public abstract void AddToListBox(ListBox listBox);
    }
}
