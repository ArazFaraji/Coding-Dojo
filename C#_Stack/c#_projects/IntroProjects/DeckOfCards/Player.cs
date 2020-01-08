using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        string name;

        List<Card> Hand = new List<Card>();

        public Card Draw(Card card)
        {
            // Card drawedCard = cards[0];
            // Console.WriteLine($"{drawedCard.stringVal} of {drawedCard.suit} val {drawedCard.val}");
            // cards.Remove(drawedCard);
            Hand.Add(card);
            Console.WriteLine($"Card drawn is {card.stringVal} of {card.suit}");
            return card;
        } 

        public void Discard(int val)
        {
            Console.WriteLine($"Card {Hand[val].stringVal} of {Hand[val].suit} will be removed");
            Hand.RemoveAt(val);
            Console.WriteLine(Hand.Count);
        }
    }
}
