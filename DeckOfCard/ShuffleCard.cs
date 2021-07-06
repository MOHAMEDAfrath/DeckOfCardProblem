using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCard
{
    class ShuffleCard
    {
        Random random = new Random();
        public void ShufflingAndDistributing()
        {
            var suit = new List<string>
            {
                "Clubs","Diamond","Heart","Spade"
            };
            var rank = new List<string>
            {
                "2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"
            };
            string[,] distributedcards = new string[4, rank.Count];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int ransuit = random.Next(0, suit.Count);
                    int ranrank = random.Next(0, rank.Count);
                    distributedcards[i, j] = suit[ransuit] + rank[ranrank];
                    Console.Write(distributedcards[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
            
    }
}
