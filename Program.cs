using ConsoleApp2;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

internal class Program
{

    private static void Main(string[] args)
    {
        ILog logger = new Txt();
        List<Player> PlayerList = new List<Player>();
        List<Team> TeamList = new List<Team>();

        string[] input = Console.ReadLine().Split(' ').ToArray();

        while (input[0] != "exit")
        {
            switch (input[0])
            {
                case "create_team":

                    Team team = new Team(input[1]);
                    TeamList.Add(team);
                    /*                    logger.Log($"Team is created. Name: {input[1]}.");
                    */
                    break;
                case "create_player":
                    Player player = new Player("pesho", "poziciq");
                    PlayerList.Add(player);
                    /*                    logger.Log($"Player is created: Name: {player.Name}, position: {player.Position}");
                    */
                    break;
                case "add_player":
                    Team teamSearch = TeamList.FirstOrDefault(x => x.Name == input[1]);
                    Player playerSearch = PlayerList.FirstOrDefault(x => x.Name == input[1]);
                    teamSearch.AddPlayer(playerSearch);
                    break;
                case "remove_player":
                    Team teamSearch2 = TeamList.FirstOrDefault(x => x.Name == input[1]);
                    Player playerSearch2 = PlayerList.FirstOrDefault(x => x.Name == input[1]);
                    teamSearch2.AddPlayer(playerSearch2);
                    break;

            }
        }
        input = Console.ReadLine().Split(' ').ToArray();
    }
}