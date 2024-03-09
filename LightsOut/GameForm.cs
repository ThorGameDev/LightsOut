using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class GameForm : Form
    {
        public Board gameBoard;
        public PictureBox[,] tiles;
        public int game_size;
        string filename;
        public GameForm(string load_filename, int game_size_input)
        {
            filename = load_filename;
            game_size = game_size_input;
            InitializeComponent();
        }

        public GameForm(string load_filename)
        {
            filename = load_filename;
            game_size = FileManagement.LoadBoardSize(filename);
            gameBoard = FileManagement.LoadBoardState(filename);
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (gameBoard == null)
            {
                gameBoard = new Board(game_size);
            }
            tiles = new PictureBox[game_size, game_size];
            for (int x = 0; x < game_size; x++)
            {
                for (int y = 0; y < game_size; y++)
                {
                    PictureBox tile = new PictureBox();
                    int X = x;
                    int Y = y;
                    tile.Click += delegate { flip(X, Y); };
                    tile.BackColor = gameBoard.board_tiles[x, y] ? Color.White : Color.Black;
                    tile.Size = new Size(50, 50);
                    tile.Location = new Point(x * 55 + 5, y * 55 + 5);
                    tiles[x, y] = tile;
                    this.Controls.Add(tile);
                }
            }
            SaveAndQuit.Location = new Point(SaveAndQuit.Location.X, game_size * 55 + 20);
            Quit.Location = new Point(Quit.Location.X, game_size * 55 + 20);
            this.Size = new System.Drawing.Size(game_size * 55 + 24, game_size * 55 + 90);
        }
        private void flip(int X, int Y)
        {
            gameBoard.Flip(X, Y);
            bool allOff = true;
            for (int x = 0; x < game_size; x++)
            {
                for (int y = 0; y < game_size; y++)
                {
                    tiles[x,y].BackColor = gameBoard.board_tiles[x,y] ? Color.White : Color.Black;
                    if (gameBoard.board_tiles[x,y] == true)
                    {
                        allOff = false;
                    }
                }
            }
            if (allOff)
            {
                Victory();   
            }
        }

        public void Victory()
        {
            FileManagement.DestroyEndedGame(filename);

            this.Hide();
            VictoryForm victory = new VictoryForm();
            victory.Show();
            victory.FormClosing += delegate { this.Close(); };
            victory.Location = this.Location;
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            FileManagement.SaveBoardState(filename, gameBoard);
            this.Close();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
