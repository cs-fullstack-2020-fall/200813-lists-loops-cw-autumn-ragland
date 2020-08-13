using System;
using System.Collections.Generic;

class SoccerPlayer : Player
{
   private List<string> sponsors = new List<string>();
   public SoccerPlayer(string name, string team) : base(name, team)
   {
       // inherited from base class
   }

   public void UpdateSponsors()
   {
       Console.Write("Enter a sponsor or done to quit : "); // prompt
       string newSponsor = Console.ReadLine(); // saving input
       while(newSponsor != "done") // as long as user input is not "done" keep looping
       {
           this.sponsors.Add(newSponsor); // add to list
           Console.Write("Enter a sponsor or done to quit : ");
           newSponsor = Console.ReadLine(); // update value
       }

        // output number of items in list
        Console.WriteLine($"The total number of {this.name}'s sponsors is : {this.sponsors.Count}");

        // iterate through list - output each element
        this.sponsors.ForEach(sponsor => Console.WriteLine($"Sponsor : {sponsor}"));
   }
   public void RemoveSponsor(string sponsor)
   {
       if(this.sponsors.IndexOf(sponsor) >= 0)
       {
           this.sponsors.Remove(sponsor);
           Console.WriteLine($"{sponsor} was removed from the list\n{this.name} now has {this.sponsors.Count} sponsors");
       } else {
           Console.WriteLine($"{sponsor} was not found in the list");
       }
   }
}