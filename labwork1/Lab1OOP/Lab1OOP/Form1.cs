﻿using System;
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
        private bool drawCircle = false;
        private bool drawEllipse = false;
        private bool drawParallelogram = false;
        private bool drawRectangle = false;
        private bool drawSquare = false;
        private bool drawLine = false;  

        private Parallelogram polygon = new Parallelogram();
        private Rectangle Rect = new Rectangle();
        private Square sq = new Square();
        private Ellipse ellipse = new Ellipse();
        private Circle circle = new Circle();   
        private Line line = new Line(); 

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
            if (drawParallelogram)
            {
                polygon.Draw(graphics, points);
                drawParallelogram = false;
            }
            else if (drawRectangle)
            {
                Rect.Draw(graphics, points);
                drawRectangle = false;
            }
            else if (drawSquare)
            {
                sq.Draw(graphics, points);
                drawSquare = false;
            }
            else if (drawEllipse)
            {
                ellipse.Draw(graphics, points);
                drawEllipse = false;
            }
            else if (drawCircle)
            {
                circle.Draw(graphics, points);
                drawCircle = false;
            }
            else if (drawLine)
            {
                line.Draw(graphics, points);    
                drawLine = false;
            }
        }

        private void PrintParallelogramButton_Click(object sender, EventArgs e)
        {

            drawParallelogram = true;
            polygon.Message();
        }

        private void PaintRectangleButton_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
            Rect.Message();
        }

        private void PaintSquarebutton_Click(object sender, EventArgs e)
        {
            drawSquare = true;
            sq.Message();
        }

        private void PaintSquarebutton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawLine(Pens.Black, 200, 0, 200, 500);
        }

        private void PaintEllipsebutton_Click(object sender, EventArgs e)
        {
            drawEllipse = true;
            ellipse.Message();
        }

        private void PaintCirclebutton_Click(object sender, EventArgs e)
        {
            drawCircle = true;
            circle.Message();
        }

        private void PaintLinebutton_Click(object sender, EventArgs e)
        {
            drawLine=true;
            line.Message();
        }
    }
}
