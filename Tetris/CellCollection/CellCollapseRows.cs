using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellCollapseRows
    {
        /// Déplace toutes les cellules "supérieures" vers le bas pour remplir les lignes complétées spécifiées.

        public void CollapseRows(List<int> rows)
        {
            var selectedCells = _cells.Where(x => rows.Contains(x.Row));

            List<Cell> toRemove = new List<Cell>();
            foreach (var cell in selectedCells)
            {
                toRemove.Add(cell);
            }

            _cells.RemoveAll(x => toRemove.Contains(x));

            foreach (var cell in _cells)
            {
                int numberOfLessRows = rows.Where(x => x <= cell.Row).Count();
                cell.Row -= numberOfLessRows;
            }
        }
    }
}