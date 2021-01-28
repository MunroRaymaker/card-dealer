using System;

namespace card_dealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dealing cards");

            var dealer = new Deck();
            dealer.Deal(3);
        }
    }
}