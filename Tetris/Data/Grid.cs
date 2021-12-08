using System;

namespace BlazorApp.Data
{
     public class Grid
    {
        public int Width { get; } = 10;
        public int Height { get; } = 20;

        public Grid() {
        }
        // public CellCollection Cells { get; set; } = new CellCollection();

        // public GameState State { get; set; } = GameState.NotStarted;

        // public bool IsStarted
        // {
        //     get
        //     {
        //         return State == GameState.Playing 
        //                || State == GameState.GameOver;
        //     }
        }
    }

