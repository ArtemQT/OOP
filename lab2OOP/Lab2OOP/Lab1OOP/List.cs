using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OOP
{
    public class FigureList
    {
        private List<Figure> ListOfFigures = new List<Figure>();

        public void AddList(Figure figure, ListBox list)
        {
            ListOfFigures.Add(figure);
            figure.AddToListBox(list);
        }

        public void RemoveList(ListBox list)
        {
            ListOfFigures.Clear();
            list.Items.Clear();
        }

        public void RemoveLastChild(ListBox list)
        {
            ListOfFigures.RemoveAt(ListOfFigures.Count - 1);
            list.Items.RemoveAt(list.Items.Count - 1);
        }
        public void DrawFromList(Graphics g)
        {
            foreach (Figure f in ListOfFigures)
            {
                f.Draw(g);
            }
        }
    }
}
