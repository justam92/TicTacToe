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
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameBoard gameBoard = new GameBoard();
            gameBoard.AddPlayers(namePlayer1.Text, surnamePlayer1.Text, namePlayer2.Text, surnamePlayer2.Text);
            gameBoard.ShowDialog();
            this.Close();
        }

        private void namePlayer1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Players_Load(object sender, EventArgs e)
        {
            namePlayer1.Text = "Imię gracza pierwszego";
            surnamePlayer1.Text = "Nazwisko gracza pierwszego";

            namePlayer2.Text = "Imię gracza drugiego";
            surnamePlayer2.Text = "Nazwisko gracza drugiego";
        }

        private void namePlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            if (namePlayer1.Text == "Imię gracza pierwszego")
            {
                namePlayer1.Text = "";
            }
        }

        private void surnamePlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            if (surnamePlayer1.Text == "Nazwisko gracza pierwszego")
            {
                surnamePlayer1.Text = "";
            }
        }

        private void namePlayer2_MouseClick(object sender, MouseEventArgs e)
        {
            if(namePlayer2.Text == "Imię gracza drugiego"){
                namePlayer2.Text = "";
            }
        }

        private void surnamePlayer2_MouseClick(object sender, MouseEventArgs e)
        {
            if(surnamePlayer2.Text == "Nazwisko gracza drugiego")
            {
                surnamePlayer2.Text = "";
            }
        }
    }
}
