using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Player(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
