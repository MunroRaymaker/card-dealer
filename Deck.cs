using System;
using System.Collections.Generic;
using System.Linq;

namespace card_dealer
{
    // Represents a deck of cards
    public class Deck
    {
        private IList<Card> cards = new List<Card>();

        public Deck()
        {
            Reset();
            Shuffle();
        }

        public void Reset()
        {
            cards.Clear();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var item in Enumerable.Range(2,10))
                {
                    cards.Add(new Card(suit, item.ToString()));
                }
                cards.Add(new Card(suit, "J"));
                cards.Add(new Card(suit, "Q"));
                cards.Add(new Card(suit, "K"));
                cards.Add(new Card(suit, "A"));
            }         
        }

        public void Deal(int count)
        {
            Random rnd = new Random();            
            for (int i = 0; i < count; i++)
            {            
                var idx = rnd.Next(0, cards.Count - 1);
                string card = cards[idx].ToString();
                cards.RemoveAt(idx);
                Console.WriteLine("Card dealt: " + card);
            }
        }
        
        public void Shuffle()
        {
            Random rnd = new Random();
                       
            for (int i = 0; i < cards.Count; i++)
            {
                var tmp = cards[i];
                var newIndex = rnd.Next(0, cards.Count - 1);
                cards[i] = cards[newIndex];
                cards[newIndex] = tmp;
            }                
        }
    }
 }