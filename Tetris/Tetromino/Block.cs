
using BlazorGames.Models.Tetris.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tetris.Tetromino
{
    /// Le Block n'a pas de rotation.
    /// X X
    /// X X
    public class Block : Tetromino, TetrominoCanMove, TetrominoDrop, TetrominoMove, TetrominoRotate, TetrominoVar
    {
        public Block(Grid grid) : base(grid) { }

        public override TetrominoStyle Style => TetrominoStyle.Block;

        public override string CssClass => "tetris-yellow-cell";

        public override CellCollection CoveredCells
        {
            get
            {
                CellCollection cells = new CellCollection();
                cells.Add(CenterPieceRow, CenterPieceColumn);
                cells.Add(CenterPieceRow - 1, CenterPieceColumn);
                cells.Add(CenterPieceRow, CenterPieceColumn + 1);
                cells.Add(CenterPieceRow - 1, CenterPieceColumn + 1);
                return cells;
            }
        }
    }
}