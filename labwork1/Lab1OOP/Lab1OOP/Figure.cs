using System;
using System.Drawing;


namespace Lab1OOP
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics g, Point p);
        public abstract void Message();
    }
}
