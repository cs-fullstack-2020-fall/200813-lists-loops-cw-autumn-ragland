# 20 08 13 Lists and Loops CW
### Set Up
- Create a new .NET console application by running `dotnet new console -o Classwork`
- In the Program class Main method change the default output to `20 08 13 Classwork`
- Create `Player` class
- Create a `SoccerPlayer` class that extends the `Player` class

### Assignment
### Part 1
- The base class `Player` should have properties : name(string), team(string), stats(struct with properties totalGames, gamesWon, and gamesLoss)
- Define the name and team in the constructor
- Define a method to display the player's name and team
- Define a method to update a player's stats and display the updated stats

### Part 2
- In the `SoccerPlayer` class inherit all properties from the `Player` base class and add the property sponsors(list of strings)
- Define a method to allow the user to add multiple sponsors to a soccer player's list of sponsors until they input 'done' then display the number of sponsor total and all sponsor in the sponsor list
- Define a method that allows a user to remove a sponsor from the sponsor list by name if the sponsor is in the list

### Part 3
- Create an instance of the `Player` class 
- Create an instance of the `SoccerPlayer` class
- Use the appropriate methods on each instance