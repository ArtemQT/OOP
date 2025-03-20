using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1OOP
{
    public partial class Form1 : Form
    {

        private Figure CurrentFigure = null;
        private FigureList ListOfFigures = new FigureList();

        public Form1()
        {
            InitializeComponent();

            this.Width = 1000;
            this.Height = 800;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Y <= 200 || FigurecomboBox.SelectedIndex == -1 || textBox1.Text == "" || textBox2.Text == "")
                return;
            string StrFigure = FigurecomboBox.SelectedItem.ToString();

            int param1 = Convert.ToInt32(textBox1.Text);
            int param2 = Convert.ToInt32(textBox2.Text);
            if ((param2 <= 200 && StrFigure == "Линия") || (param1 == 0 || param2 == 0))
                return;

            CurrentFigure = Factory.CreateShape(StrFigure, e.X, e.Y, param1, param2);
            ListOfFigures.AddList(CurrentFigure, HistoryListBox);

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawLine(Pens.Black, 0, 200, this.Width, 200);
            g.FillRectangle(Brushes.AntiqueWhite, 0, 0, this.Width, 200);

            ListOfFigures.DrawFromList(g);
        }



        private void DeleteLastbutton_Click(object sender, EventArgs e)
        {
            if (HistoryListBox.Items.Count > 0)
            {
                ListOfFigures.RemoveLastChild(HistoryListBox);
                this.Invalidate();
            }
        }

        private void Cleanbutton_Click(object sender, EventArgs e)
        {
            ListOfFigures.RemoveList(HistoryListBox);
            this.Invalidate();
        }

        private void FigurecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FigurecomboBox.SelectedIndex)
            {
                case 0:
                    {
                        textBox2.Visible = true;
                        label2.Visible = true;
                        label1.Text = "Ширина";
                        label2.Text = "Высота";
                        break;
                    }
                case 1:
                    {
                        textBox2.Visible = true;
                        label2.Visible = true;
                        label1.Text = "Ширина";
                        label2.Text = "Высота";
                        break;
                    }
                case 2:
                    {
                        label1.Text = "Ширина и высота";
                        label2.Visible = false;
                        textBox2.Visible = false;
                        break;
                    }
                case 3:
                    {
                        label2.Visible = true;
                        textBox2.Visible = true;

                        label1.Text = "Ширина";
                        label2.Text = "Высота";
                        break;
                    }
                case 4:
                    {

                        label1.Text = "Радиус";

                        label2.Visible = false;
                        textBox2.Visible = false;
                        break;
                    }
                case 5:
                    {
                        label2.Visible = true;
                        textBox2.Visible = true;

                        label1.Text = "Координата x";
                        label2.Text = "Координата y";
                        break;
                    }
            }
        }
    }
}