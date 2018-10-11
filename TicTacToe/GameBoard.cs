using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameBoard : Form
    {
        private DatabasePlayers databasePlayers;
        private Game game;

        bool round = true;
        int numberOfRounds = 0;
        
        public GameBoard()
        {
            InitializeComponent();
        }

        public void AddPlayers(string namePlayer1, string surnamePlayer1, string namePlayer2, string surnamePlayer2)
        {
            databasePlayers = new DatabasePlayers();
            game = new Game();

            game.AddPlayers(namePlayer1, surnamePlayer1, namePlayer2, surnamePlayer2, databasePlayers);
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.EndOfGame();
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (round)
                button.Text = "X";
            else
                button.Text = "O";

            round = !round;

            button.Enabled = false;
            numberOfRounds++;
            CheckWhoIsWinner();
        }

        private void CheckWhoIsWinner()
        {
            game.CountNumberOfWins(area11, area12, area13, area21, area22, area23, area31, area32, area33, round, numberOfRounds, numberOfWinsForY, numberOfWinsForX, numberOfDraws, Controls);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            round = true;
            numberOfRounds = 0;
            game.StartingGame(round, numberOfRounds, Controls);
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (round)
                    button.Text = "X";
                else
                    button.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
            }
        }

        private void resetWinningsCountToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            numberOfWinsForY.Text = "0";
            numberOfWinsForX.Text = "0";
            numberOfDraws.Text = "0";
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

            label1.Text = databasePlayers.player1.Name + " " + databasePlayers.player1.Surname;
            label3.Text = databasePlayers.player2.Name + " " + databasePlayers.player2.Surname;
        }
    }
}
