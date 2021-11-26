using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellAdd
    {
        /// Ajoute une nouvelle cellule 
        public void Add(int row, int column)
        {
            _cells.Add(new Cell(row, column));
        }
    }
}