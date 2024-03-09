using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut
{
    public class Board
    {
        public int boardSize;
        public bool[,] board_tiles;
        public Board(int size)
        {
            boardSize = size;
            board_tiles = new bool[size, size];
            Random randomizer = new Random();
            for(int x = 0 ; x < size; x++)
            {
                for(int y = 0 ; y < size; y++)
                {
                    if (randomizer.Next(0,2) == 0)
                    {
                        Flip(x, y);
                    }
                }
            }
        }
        public Board(bool[,] tiles)
        {
            board_tiles = tiles;
            boardSize = tiles.GetLength(0);
        }
        public void Flip(int x, in int y)
        {
            Flip_sub(x,y);
            Flip_sub(x+1,y);
            Flip_sub(x-1,y);
            Flip_sub(x,y+1);
            Flip_sub(x,y-1);
        }
        public void Flip_sub(int x, in int y)
        {
            if (x < 0 || x >= boardSize || y < 0 || y >= boardSize)
            {
                return;
            }
            board_tiles[x, y] = !board_tiles[x, y];
        }

    }
}
