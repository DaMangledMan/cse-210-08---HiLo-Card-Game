class Deck
{

    // creates a storage variable
    List <int> deck = new List <int> ();


    // builds the deck and stores it inside the afformentioned variable
    public Deck()
    {
        for (int i = 1; i <= 13; i += 1)
        {
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
        }
    }


    // draws one card from the deck and discards the card after showing it to the user
    public int draw()
    {
        var random = new Random();
        int index = random.Next(deck.Count);
        int card = deck[index];
        deck.RemoveAt(index);
        return card;
    }
}
