class HiLo
{
    /*
            main 
                runs through everything else that has been created
    */

    static void Main()
    {
        Deck deck = new Deck();
        int card = draw(deck);
    }



    /*
            draw_phase
                draws a card and shows it to player
    */

    // call a function from the deck class



    /*
            player_declaration
                takes high/low input from player
    */
    
    static string declare()
    {
        do
        {
            Console.WriteLine("Do you think it is 'Higher' or 'Lower'?");
            string choice = Console.ReadLine() ?? "";
            if (choice == "higher" || choice == "lower")
            {
                return choice;
            }
            else{
                Console.WriteLine("Unrecognized input.");
            }
        } while (true);
    }




    /*
            correctness_calculation
                compares two cards to determine correctness of player input
    */
    
    static string correct(int prevCard, int currCard, string choice)
    {
        string right = "right";
        string wrong = "wrong";
        string same = "same";
        
        if (currCard == prevCard)
        {
            return same;
        }
        else
        {
            if (choice.ToLower() == "higher")
            {
                if (currCard > prevCard)
                {
                    return right;
                }
                else
                {
                    return wrong;
                }
            }
            else
            {
                if (currCard < prevCard)
                {
                    return right;
                }
                else
                {
                    return wrong;
                }
            }
        }
    }




    /*
            point_distribution
                distibutes points and show it to player
    */





    /*
            replay_question
                asks player if they want to play another round
    */


}