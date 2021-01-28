
namespace card_dealer
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string Value { get; set; }

        public Card(Suit s, string v)
        {
            Suit = s;
            Value = v;
        }

        public override string ToString()
        {
            return $"{Suit}{Value}";            
        }
    }
 }