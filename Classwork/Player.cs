using System;
class Player
{
    protected string name;
    protected string team;
    protected Statistics stats;
    // constructor 
    public Player(string name, string team)
    {
        this.name = name;
        this.team = team;
    }
    // display the player's name and team
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Name : {this.name}\nPlayer Team : {this.team}");
    }
    // update a player's stats and display the updated stats
    public void UpdateStats()
    {
        // prompt for stats values and update each prop of the strutc 
        Console.Write($"Enter {this.name}'s total games : ");
        this.stats.totalGames = Int16.Parse(Console.ReadLine());

        Console.Write($"Enter {this.name}'s games won : ");
        this.stats.gamesWon = Int16.Parse(Console.ReadLine());

        Console.Write($"Enter {this.name}'s games lost : ");
        this.stats.gamesLost = Int16.Parse(Console.ReadLine());

        // display stats values
        Console.WriteLine($"Total Games : {this.stats.totalGames}\nTotal Won : {this.stats.gamesWon}\nTotal Lost : {this.stats.gamesLost}");
    }

}
// struct with properties totalGames, gamesWon, and gamesLost 
struct Statistics
{
    public int totalGames;
    public int gamesLost;
    public int gamesWon;
}