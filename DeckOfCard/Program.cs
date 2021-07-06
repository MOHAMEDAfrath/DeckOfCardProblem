using System;
using System.Collections.Generic;

namespace DeckOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Deck of Cards Problem");
            ShuffleCard shuffleCard = new ShuffleCard();
            shuffleCard.ShufflingAndDistributing();
        }
    }
}
