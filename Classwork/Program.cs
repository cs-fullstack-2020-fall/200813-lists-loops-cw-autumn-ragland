using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 08 13 Classwork");
            Player player1 = new Player("Player 1", "Team 2");
            // player1.DisplayPlayerInfo();
            // player1.UpdateStats();
            SoccerPlayer player2 = new SoccerPlayer("Player 2", "Team 3");
            player2.UpdateSponsors();
            player2.RemoveSponsor("spon 1");
        }
    }
}
