 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tetris.Tetromino
{
    public class TetrominoCanMove
    {
        // Renvoie si le tétromino peut ou non se déplacer dans n'importe quelle direction (bas, gauche, droite)
    public bool CanMove()
    {
        return CanMoveDown() || CanMoveLeft() || CanMoveRight();
    }

        /// Renvoie si le tétromino peut ou non descendre.

    public bool CanMoveDown()
    {
        //Pour chacun des espaces couverts, obtenez l'espace immédiatement en dessous

        foreach (var coord in CoveredCells.GetLowest())
        {
            if (Grid.Cells.Contains(coord.Row - 1, coord.Column))
                return false;
        }

        //Si l'un des espaces couverts se trouve actuellement dans la rangée la plus basse, la pièce ne peut pas descendre.

        if (CoveredCells.HasRow(1))
            return false;

        return true;
    }

        /// Renvoie si le tétromino peut ou non se déplacer vers la droite
    public bool CanMoveRight()
    {
        //Pour chacun des espaces couverts, obtenez l'espace immédiatement à droite

        foreach (var cell in CoveredCells.GetRightmost())
        {
            if (Grid.Cells.Contains(cell.Row, cell.Column + 1))
                return false;
        }

        //Si l'un des espaces couverts se trouve actuellement dans la colonne la plus à droite, la pièce ne peut pas se déplacer vers la droite.

        if (CoveredCells.HasColumn(Grid.Width))
            return false;

            return true;
    }

        /// Renvoie si le tétromino peut ou non se déplacer vers la gauche.
    public bool CanMoveLeft()
    {
        //Pour chacun des espaces couverts, obtenez l'espace immédiatement à gauche

        foreach (var cell in CoveredCells.GetLeftmost())
        {
            if (Grid.Cells.Contains(cell.Row, cell.Column - 1))
                return false;
        }

        //Si l'un des espaces couverts se trouve actuellement dans la colonne la plus à gauche, la pièce ne peut pas se déplacer vers la gauche.

        if (CoveredCells.HasColumn(1))
            return false;

        return true;
    }
        
    }
    
    
}