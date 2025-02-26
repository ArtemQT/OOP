using System;
using System.Collections.Generic;
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
    }
}
