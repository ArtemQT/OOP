using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
    public partial class Form1 : Form
    {

        private Figure CurrentFigure = null;

        public Form1()  
        {
            InitializeComponent();

            this.Width = 800;
            this.Height = 500;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false; 
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.X <= 200)
                return;
            Graphics graphics = CreateGraphics();
            Point points = new Point(e.X, e.Y);
            
            if (CurrentFigure != null)
            {
                CurrentFigure.Draw(graphics, points);
            }
        }

        private void PrintParallelogramButton_Click(object sender, EventArgs e)
        {

            CurrentFigure = new Parallelogram();
            CurrentFigure.Message();
        }

        private void PaintRectangleButton_Click(object sender, EventArgs e)
        {
            CurrentFigure = new Rectangle();
            CurrentFigure.Message();
        }

        private void PaintSquarebutton_Click(object sender, EventArgs e)
        {
            CurrentFigure = new Square();
            CurrentFigure.Message();
        }


        private void PaintEllipsebutton_Click(object sender, EventArgs e)
        {
            CurrentFigure = new Ellipse();
            CurrentFigure.Message();
        }

        private void PaintCirclebutton_Click(object sender, EventArgs e)
        {
            CurrentFigure = new Circle();
            CurrentFigure.Message();
        }

        private void PaintLinebutton_Click(object sender, EventArgs e)
        {
            CurrentFigure = new Line();
            CurrentFigure.Message();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawLine(Pens.Black, 200, 0, 200, 500);
            g.FillRectangle(Brushes.AntiqueWhite, 0, 0, 200, 500);
        }
    }
}
