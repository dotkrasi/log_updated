using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Player : IPlayer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Player(string name, string position)
        {
            this.name = name;
            this.position = position;
        }

        public override string ToString()
        {
            return $"position: {this.Position}, Name: {this.Name}";
        }

    }
}
