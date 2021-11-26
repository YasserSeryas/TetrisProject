using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellAddMany
    {
         /// Ajoute plusieurs nouvelles cellules et leur attribue à chacune la classe CSS spécifiée.

        public void AddMany(List<Cell> cells, string cssClass)
        {
            foreach(var cell in cells)
            {
                _cells.Add(new Cell(cell.Row, cell.Column, cssClass));
            }
        }
    }
}