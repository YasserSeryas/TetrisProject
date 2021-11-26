using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellLowest
    {
        /// Obtient la cellule la plus basse (valeur de ligne la plus basse) de la collection.
        public List<Cell> GetLowest()
        {
            List<Cell> cells = new List<Cell>();
            foreach(var cell in _cells)
            {
                if(!Contains(cell.Row - 1, cell.Column))
                {
                    cells.Add(cell);
                }
            }

            return cells;
        }
    }
}