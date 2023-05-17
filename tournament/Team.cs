using static System.Console;

public class Team{

    private List<Player> _players = new List<Player>();
    private string _name;

    public Team(string name){
        _name = name;
    }

    public void AddPlayer(Player p){
        _players.Add(p);
    }

    public void DisplayRoster(){
        WriteLine($"{_name}");
        foreach(Player player in _players){
            WriteLine(player.Display());
        }
    }

}
