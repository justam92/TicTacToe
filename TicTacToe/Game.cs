using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Game
    {
        private DatabasePlayers databasePlayers;

        public void AddPlayers(string namePlayer1, string surnamePlayer1, string namePlayer2, string surnamePlayer2, DatabasePlayers databasePlayers)
        {
            Player firstPlayer = new Player(namePlayer1, surnamePlayer1);
            databasePlayers.player1 = firstPlayer;

            Player secondPlayer = new Player(namePlayer2, surnamePlayer2);
            databasePlayers.player2 = secondPlayer;

            this.databasePlayers = databasePlayers;
        }

        public void StartingGame(bool round, int numberOfRound, Control.ControlCollection Controls)
        {

            foreach (Control c in Controls)
            {
                try
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }
                catch { }
            }
        }

        public void AddPlayers()
        {
            Players players = new Players();
            players.ShowDialog();
        }

        public void CountNumberOfWins(Button area11, Button area12, Button area13, Button area21, Button area22, Button area23, Button area31, Button area32, Button area33, bool round, int numberOfRound, Label numberOfWinsForO, Label numberOfWinsForX, Label numberOfDraws, Control.ControlCollection Controls)
        {
            bool thisIsWinner = false;

            if ((area11.Text == area12.Text) && (area12.Text == area13.Text) && (!area11.Enabled))
                thisIsWinner = true;
            else if ((area21.Text == area22.Text) && (area22.Text == area23.Text) && (!area21.Enabled))
                thisIsWinner = true;
            else if ((area31.Text == area32.Text) && (area32.Text == area33.Text) && (!area31.Enabled))
                thisIsWinner = true;
            else if ((area11.Text == area21.Text) && (area21.Text == area31.Text) && (!area11.Enabled))
                thisIsWinner = true;
            else if ((area12.Text == area22.Text) && (area22.Text == area32.Text) && (!area12.Enabled))
                thisIsWinner = true;
            else if ((area13.Text == area23.Text) && (area23.Text == area33.Text) && (!area13.Enabled))
                thisIsWinner = true;
            else if ((area11.Text == area22.Text) && (area22.Text == area33.Text) && (!area11.Enabled))
                thisIsWinner = true;
            else if ((area13.Text == area22.Text) && (area22.Text == area31.Text) && (!area31.Enabled))
                thisIsWinner = true;

            if (thisIsWinner)
            {
                TurnOffButton(Controls);

                string winner = "";
                if (round)
                {
                    winner = databasePlayers.player2.Name;
                    numberOfWinsForO.Text = (Int32.Parse(numberOfWinsForO.Text) + 1).ToString();
                }
                else
                {
                    winner = databasePlayers.player1.Name;
                    numberOfWinsForX.Text = (Int32.Parse(numberOfWinsForX.Text) + 1).ToString();
                }
                MessageBox.Show("Wygrywa: " + winner + "!", "Yay!");
            }
            else
            {
                if (numberOfRound == 9)
                {
                    numberOfDraws.Text = (Int32.Parse(numberOfDraws.Text) + 1).ToString();
                    MessageBox.Show("Remis!", "Ale wtopa!");
                }
            }
        }

        private void TurnOffButton(Control.ControlCollection Controls)
        {
            
                foreach (Control c in Controls)
                {
                    Type controlType = c.GetType();

                    if (controlType.Name.Equals("Button"))
                    {
                        c.Enabled = false;
                    }
                }
            
        }

        public void EndOfGame()
        {
            Application.Exit();
        }
    }
}
