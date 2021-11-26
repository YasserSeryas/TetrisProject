using System.Collections.Generic;
using System.Linq;

namespace Tetris.CellCollection
{
    public class CellMost
    {
        /// Obtient la cellule la plus à droite (valeur de colonne la plus élevée) de la collection.
        public List<Cell> GetRightmost()
        {
            List<Cell> cells = new List<Cell>();
            foreach (var cell in _cells)
            {
                if (!Contains(cell.Row, cell.Column + 1))
                {
                    cells.Add(cell);
                }
            }

            return cells;
        }


        /// Obtient la cellule la plus à gauche (valeur de colonne la plus basse) de la collection.

        public List<Cell> GetLeftmost()
        {
            List<Cell> cells = new List<Cell>();
            foreach (var cell in _cells)
            {
                if (!Contains(cell.Row, cell.Column - 1))
                {
                    cells.Add(cell);
                }
            }

            return cells;
        }



    }
}