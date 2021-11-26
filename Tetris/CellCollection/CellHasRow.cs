using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellHasRow
    {
        /// Renvoie true si une cellule de la collection se trouve dans la ligne spécifiée.

        public bool HasRow(int row)
        {
            return _cells.Any(c => c.Row == row);
        }
    }
}