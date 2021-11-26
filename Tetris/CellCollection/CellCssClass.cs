using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellCssClass
    {
         /// Définit la classe CSS sur chaque cellule d'une ligne entière.

        public void SetCssClass(int row, string cssClass)
        {
            _cells.Where(x => x.Row == row).ToList().ForEach(x => x.CssClass = cssClass);
        }
    }
}