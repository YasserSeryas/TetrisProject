using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellAllInRow
    {
        // Renvoie toutes les cellules occupées dans une ligne donnée.

        public List<Cell> GetAllInRow(int row)
        {
            return _cells.Where(x => x.Row == row).ToList();
        }

    }
}