namespace MTCG_project;

public class Deck
{
    private readonly List<Card> _cards = [];

    public void ListCounter()
    {
        Console.WriteLine(_cards.Count);   
    }

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
}