using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lab1OOP
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics g, Point p);
        public abstract void Message();
        public abstract void AddToListBox(ListBox listBox);
    }
}
