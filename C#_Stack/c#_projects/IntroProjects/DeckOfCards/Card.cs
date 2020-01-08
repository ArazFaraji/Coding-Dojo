using System;

namespace DeckOfCards
{
    class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card(string sval, string Suit, int num)
        {
            stringVal = sval;
            suit = Suit;
            val = num;
        }
    }
}
