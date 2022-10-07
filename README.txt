Title:
    HiLo Card Game

Author(s):
    Jacob Hutchens - jacobh52003@gmail.com

Description:
    A program to walk the player through the card game of HiLo. 

Program Structure:
    steps for each turn:
        1  dealer draws
        2  player declares higher or lower
        3  dealer draws
        4  reveals if player was correct
        5  distibutes points
        6  return to step 2
    programs process:
        main 
            runs through everything else that has been created
        class_deck
            deck_creation
                builds the deck from nothing and stores it as an object
            draw_phase
                draws a card, shows it to player, and discards it
        player_declaration
            takes high/low input from player
        correctness_calculation
            compares two cards to determine correctness of player input
        class_points
            start_points
                sets the starting point count as an object
            point_distribution
                adds or subtracts points based on player correctness
        replay_question
            asks player if they want to play another round

