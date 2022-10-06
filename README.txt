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
        draw_phase
            draws a card and shows it to player
        player_declaration
            takes high/low input from player
        correctness_calculation
            compares two cards to determine correctness of player input
        point_distribution
            distibutes points and show it to player
        replay_question
            asks player if they want to play another round

