using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellHasColumn
    {
        /// Renvoie vrai s'il y a des cellules occupées dans la colonne donnée.
        public bool HasColumn(int column)
        {
            return _cells.Any(c => c.Column == column);
        }

    }
}