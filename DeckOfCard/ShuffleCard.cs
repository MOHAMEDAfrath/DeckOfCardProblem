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
                "Club","Diamond","Heart","Spade"
            };
            var rank = new List<string>
            {
                "2","3","4","5","6","7","8","9","10","J","Q","K","A"
            };
            LinkedList<string> cards = new LinkedList<string>(); 
            LinkedList<string> players = new LinkedList<string>();
            for (int i = 0; i < suit.Count; i++)
            {
                foreach (var mem in rank)
                {
                    cards.AddLast(suit[i] + mem);
                    
                }
            }
            foreach(var member in cards)
            {
                Console.Write(member+ " ");
               
            }
            Console.WriteLine(" ");
            Dictionary<string, SortedSet<string>> playersWithCards  = new Dictionary<string, SortedSet<string>>();
            
            int player = 1;
            while (player != 5)
            {
                SortedSet<string> card = new SortedSet<string>();
                while (card.Count < 9)
                {
                    int ransuit = random.Next(0, suit.Count);
                    int ranrank = random.Next(0, rank.Count);
                    card.Add(rank[ranrank]+suit[ransuit]);
                }
                playersWithCards.Add(("player" + player), card);
                player++;

            }
            foreach(var member in playersWithCards)
            {
                players.AddLast(member.Key);
                Console.WriteLine(member.Key);
                foreach (var members in member.Value.Reverse()) 
                {
                    
                        Console.Write(members+ " ");
                    
                }
                Console.WriteLine(" ");
               
            }
               
        }
      
            
    }
    
}
