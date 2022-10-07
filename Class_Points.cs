class Points
{

    // creates a new variable to store the current point count
    int points = new int ();


    // sets the starting point count at the begining of the game
    public void setPoints()
    {
        this.points = 300;
    }


    // adds or subtracts points based on whether the player was correct
    public void calculate(string correct)
    {
        if (correct == "right")
        {
            this.points += 100;
        }
        else
        {
            this.points += -75;
        }
        Console.WriteLine($"Your current point count is {points}");
    }
}
