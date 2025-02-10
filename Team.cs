using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Team
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Player> players;

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }
        private ILog logger;

        public ILog Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        public Team(string name)
        {
            this.name = name;
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
/*            logger.Log($"Player: {player.Name}, with position: {player.Position} has joined {Name}.");
*/
        }

        public void RemovePlayer(string playerName)
        {
            Player player = new Player(playerName, "poziciq");
            if (player != null)
            {
                players.Remove(player);
            }
/*            log.Log($"{player} has left the game.");
*/        }

        public void PrintTeamTxt(string filePath, ILog log)
        { 
            List<string> info = new List<string>();
            info.Add($"Team: {this.Name}");
            info.Add($"Players: ");
            foreach (Player player in players)
            {
                info.Add(player.ToString());
            }
            log.Log(filePath,info);
        }

    }
}
