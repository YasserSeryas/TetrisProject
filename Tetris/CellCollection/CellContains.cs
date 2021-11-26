using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellContains
    {
         /// Renvoie vrai si la cellule est occupée.
   
        public bool Contains(int row, int column)
        {
            return _cells.Any(c => c.Row == row && c.Column == column);
        }
    }
}