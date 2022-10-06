class Deck
{
    List <int> deck = new List <int> ();

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

    public int draw(List<int> deck)
    {
        int index = Random.Next(deck.Count);
        int card = deck[index];
        deck.RemoveAt(index);
        return card;
    }
    
}