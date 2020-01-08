using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck newDeck = new Deck();
            Deck deckInUse = newDeck;

            deckInUse.Deal();
            deckInUse.Deal();
            deckInUse.Deal();
            Console.WriteLine(deckInUse.cards.Count);

            deckInUse = deckInUse.Reset();

            deckInUse.Deal();
            deckInUse.Deal();
            Console.WriteLine(deckInUse.cards.Count);

            // newDeck.Reset();

            deckInUse.Shuffle();
            deckInUse.Shuffle();
            deckInUse.Shuffle();

            Player p1 = new Player();

            p1.Draw(deckInUse.GiveCardAtTop());
            p1.Draw(deckInUse.GiveCardAtTop());
            p1.Draw(deckInUse.GiveCardAtTop());
            p1.Draw(deckInUse.GiveCardAtTop());

            p1.Discard(2);




        }
    }
}
