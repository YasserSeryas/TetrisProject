using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tetris.Tetromino
{
    public class Tetromino
    {
        /// <summary>
        /// Représente la grille sur laquelle ce tétromino peut se déplacer.
        /// </summary>
        public Grid Grid { get; set; }

        /// <summary>
        /// L'orientation actuelle de ce tétromino. Les tétrominos tournent autour de leur centre.
        /// </summary>
        public TetrominoOrientation Orientation { get; set; } = TetrominoOrientation.LeftRight;

        /// <summary>
        /// La coordonnée X de la pièce centrale.
        /// </summary>
        public int CenterPieceRow { get; set; }

        /// <summary>
        /// Le coordonnée Y de la pièce centrale
        /// </summary>
        public int CenterPieceColumn { get; set; }

        /// <summary>
        /// Le style de ce tétromino, par ex. Droit, bloc, en forme de T, etc.
        /// </summary>
        public virtual TetrominoStyle Style { get; }

        /// <summary>
        /// La classe CSS qui est unique à ce style de tetromino.
        /// </summary>
        public virtual string CssClass { get; }

        /// <summary>
        /// Une collection de tous les espaces actuellement occupés par ce tétromino.
        /// Cette collection est calculée par chaque style.
        /// </summary>
        public virtual CellCollection CoveredCells { get; }

        public Tetromino(Grid grid)
        {
            Grid = grid;
            CenterPieceRow = grid.Height;
            CenterPieceColumn = grid.Width / 2;
        }

        /// <summary>
        /// Fait pivoter le tétromino autour de la pièce centrale. Les tétrominos tournent toujours dans le sens des aiguilles d'une montre.
        /// </summary>
        public void Rotate() 
        { 
            switch(Orientation)
            {
                case TetrominoOrientation.UpDown:
                    Orientation = TetrominoOrientation.RightLeft;
                    break;

                case TetrominoOrientation.RightLeft:
                    Orientation = TetrominoOrientation.DownUp;
                    break;

                case TetrominoOrientation.DownUp:
                    Orientation = TetrominoOrientation.LeftRight;
                    break;

                case TetrominoOrientation.LeftRight:
                    Orientation = TetrominoOrientation.UpDown;
                    break;
            }

            var coveredSpaces = CoveredCells;

            //Si la nouvelle rotation du tétromino signifie qu'il serait en dehors du
            //zone de jeu, décalez l'espace central de manière à garder tout le tétromino visible.
            if(coveredSpaces.HasColumn(-1))
            {
                CenterPieceColumn += 2;
            }
            else if (coveredSpaces.HasColumn(12))
            {
                CenterPieceColumn -= 2;
            }
            else if (coveredSpaces.HasColumn(0))
            {
                CenterPieceColumn++;
            }
            else if (coveredSpaces.HasColumn(11))
            {
                CenterPieceColumn--;
            }
        }

        /// <summary>
        /// Déplace le tétromino d'une colonne vers la droite
        /// </summary>
        public void MoveRight()
        {
            if (CanMoveRight())
            {
                CenterPieceColumn++;
            }
        }

        /// <summary>
        /// Faites tomber le tétromino jusqu'à son point le plus bas possible.
        /// </summary>
        /// <returns>Le score obtenu en laissant tomber la pièce</returns>
        public int Drop()
        {
            int scoreCounter = 0;
            while(CanMoveDown())
            {
                MoveDown();
                scoreCounter++;
            }

            return scoreCounter;
        }

        /// <summary>
        /// Déplacez le tétromino d'une rangée vers le bas.
        /// </summary>
        public void MoveDown()
        {
            if (CanMoveDown())
            {
                CenterPieceRow--;
            }
        }

        /// <summary>
        /// Renvoie si le tétromino peut ou non se déplacer dans n'importe quelle direction (bas, gauche, droite).
        /// </summary>
        /// <returns></returns>
        public bool CanMove()
        {
            return CanMoveDown() || CanMoveLeft() || CanMoveRight();
        }

        /// <summary>
        /// Renvoie si le tétromino peut ou non descendre.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Renvoie si le tétromino peut ou non se déplacer vers la droite
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Déplace le tétromino d'une colonne vers la gauche.
        /// </summary>
        public void MoveLeft()
        {
            if (CanMoveLeft())
            {
                CenterPieceColumn--;
            }
        }

        /// <summary>
        /// Renvoie si le tétromino peut ou non se déplacer vers la gauche.
        /// </summary>
        /// <returns></returns>
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