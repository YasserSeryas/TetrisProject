using System;

namespace BlazorApp.Data
{
   public class Tetromino
   {
        public int WidthTetrominoO  { get; set;} = 2;

        public int HeightTetrominoO { get;set;}= 2;
        
        public int [,] TablTetromino { get; set;}
   }
}