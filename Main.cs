class HiLo
{
    /*
            main 
                runs through everything else that has been created
    */

    static void Main()
    {
        // creates the deck
        Deck deck = new Deck();
        
        // draws the first card to start the game
        int curr_card = Deck.draw();
        
        // starts the game loop
        do
        {
            // shows current card
            Console.WriteLine($"The current card is {card}");

            // asks if they choose higher or lower
            string choice = declare();

            // draws the next card and calculates if declaration was correct
            int prev_card = curr_card;
            int curr_card = Deck.draw();
            string correct = correct(prev_card, curr_card, choice);

            // calculates points based on correctness


            // asks player if they'd like to replay
            string replay = replay();
            if (replay == "y")
            {
                break;
            }
            else {}

        } while (true);

    }



    /*
            draw_phase
                draws a card and shows it to player until discarding it
    */

    // call a method from the deck class



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
                return choice.ToLower();
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

    // call a method from the points class



    /*
            replay_question
                asks player if they want to play another round
    */
    
    static string replay()
    {
        do 
        {
            Console.WriteLine("Would you like to play another round (y/n)");
            string ans = Console.ReadLine() ?? "";
            if (ans.ToLower() == "y" || ans.ToLower() == "n")
            {
                return ans.ToLower();
            }
            else 
            {
                Console.WriteLine("Unrecognized input.");
            }
        } while (true);
    }
}