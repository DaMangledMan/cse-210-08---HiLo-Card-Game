class Points
{


    int points = new int ();


    
    public void setPoints()
    {
        this.points = 300;
    }



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
    }
}