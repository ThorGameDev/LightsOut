using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace LightsOut
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void StartGame_Load(object sender, EventArgs e)
        {
            // If the save directory has not been created, assume that it is a new player playing
            if (!Directory.Exists("./games/"))
            {
                Directory.CreateDirectory("./games/");
                MessageBox.Show("Welcome New Player!\n" +
                    "The goal of this game is to turn all the lights to black.\n" +
                    "To play, just choose a board size, a file name, and press Play Game\n" +
                    "Pressing a square toggles its and its neibor's color.\n" +
                    "A cheat meathod of solving can be found at https://www.logicgamesonline.com/lightsout/tutorial.html\n");
                return;
            }
            // If the directory does exist, however, display all games that were saved.
            try
            {
                output_existingGames.Items.Clear();
                string[] games = Directory.GetFiles("./games/");
                foreach(string game in games)
                {
                    output_existingGames.Items.Add(game.Remove(0,8).Replace(".lob",""));
                }
            }
            catch
            {
                return;
            }
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            //Switches window to the Game window.
            //Passes the name of the game and the size as arguments
            this.Hide();
            GameForm newGame = new GameForm(input_newGameName.Text, (int)input_gameSize.Value);
            newGame.Show();
            newGame.FormClosing += delegate { this.Close(); };
            newGame.Location = this.Location;
        }

        private void output_existingGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Switches to the game window
            //Passes the filename of the game to play as an argument
            if (output_existingGames.SelectedItem == null) { return; }
            this.Hide();
            GameForm newGame = new GameForm((string)output_existingGames.SelectedItem);
            newGame.Show();
            newGame.FormClosing += delegate { this.Close(); };
            newGame.Location = this.Location;
        }

        private void GetHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The goal of this game is to turn all the lights to black.\n" +
                "To play, just choose a board size, a file name, and press Play Game\n" +
                "Pressing a square toggles its and its neibor's color.\n" +
                "A cheat meathod of solving can be found at https://www.logicgamesonline.com/lightsout/tutorial.html\n");
        }
    }
}
