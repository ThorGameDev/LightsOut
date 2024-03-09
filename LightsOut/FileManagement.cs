using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LightsOut
{
    public static class FileManagement
    {
        public static Board LoadBoardState(string name)
        {
            if(name == "")
            {
                return new Board(3);
            }
            try
            {
                StreamReader lightsOutBoard = new StreamReader($"./games/{name}.lob");
                int size = int.Parse(lightsOutBoard.ReadLine());
                bool[,] board = new bool[size, size];
                for (int x = 0; x < size; x++)
                {
                    string[] items = lightsOutBoard.ReadLine().Split(',');
                    for (int y = 0; y < size; y++)
                    {
                        board[x, y] = items[y] == "1" ? true : false;
                    }
                }
                lightsOutBoard.Close();
                return new Board(board);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Loading game failed with error {ex.Message}");
                return new Board(3);
            }
        }
        public static void SaveBoardState(string name, Board board)
        {
            if(name == "")
            {
                return;
            }
            try
            {
                StreamWriter lightsOutBoard = new StreamWriter($"./games/{name}.lob");
                int size = board.boardSize;
                lightsOutBoard.WriteLine(size);
                for(int x = 0; x < size; x++)
                {
                    string board_line = "";
                    for(int y = 0; y < size; y++)
                    {
                        board_line += board.board_tiles[x, y] ? "1," : "0,";
                    }
                    lightsOutBoard.WriteLine(board_line);
                }
                lightsOutBoard.Close();
            }
            catch(Exception ex)
            {
                if (name != "fallback")
                {
                    MessageBox.Show($"Failed to save game!\nAttempting to save as 'fallback'");
                    SaveBoardState("fallback", board);
                }
                else
                {
                    MessageBox.Show($"Fallback save failed!\nError message:\n{ex.Message}");
                }
            }
        }
        public static void DestroyEndedGame(string name)
        {
            if (name == "")
            {
                return;
            }
            try
            {
                File.Delete(name);
            }
            catch 
            { 
                return;
            }
        }
        public static int LoadBoardSize(string name)
        {
            if (name == "")
            {
                return 3;
            }
            StreamReader lightsOutBoard = new StreamReader($"./games/{name}.lob");
            int size = int.Parse(lightsOutBoard.ReadLine());
            lightsOutBoard.Close();
            return size;
        }
    }
}
