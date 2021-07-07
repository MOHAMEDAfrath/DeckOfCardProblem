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
            Console.WriteLine("Printing the entire deck");
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
            Dictionary<string, LinkedList<string>> playersWithCards  = new Dictionary<string, LinkedList<string>>();
            
            int player = 1;
            while (player != 5)
            {
                LinkedList<string> card = new LinkedList<string>();
                while (card.Count < 9)
                {
                    int ransuit = random.Next(0, suit.Count);
                    int ranrank = random.Next(0, rank.Count);
                    card.AddLast(rank[ranrank]+suit[ransuit]);
                }
                playersWithCards.Add(("player" + player), card);
                player++;

            }
            foreach(var member in playersWithCards)
            {
                players.AddLast(member.Key);
                Console.WriteLine(member.Key);


                Swapping(member.Value);
                    
                
                Console.WriteLine(" ");
               
            }
            
               
        }
        public void Swapping(LinkedList<string> playarray)
        {
            Char[] arr = { '2', '3', '4', '5', '6', '7', '8', '9' };
            LinkedList<string> sorted = new LinkedList<string>();
            var temp = new List<string>();

            foreach (string i in playarray.OrderBy(x => x))
            {
                if (arr.Contains(i[0]))
                {
                    sorted.AddLast(i);
                }
                else
                {
                    temp.Add(i);
                }
            }
            temp = temp.OrderBy(i => i).ToList();
            //Sort array a containing Ranks in alphabet
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i + 1; j < temp.Count; j++)
                {
                    if ((temp[i][0] == 'K' && temp[j][0] == 'Q') || (temp[i][0] == 'A' && temp[j][0] == 'Q') || (temp[i][0] == 'A' && temp[j][0] == 'J') || (temp[i][0] == 'A' && temp[j][0] == 'K'))
                    {
                        string tmp = temp[i];
                        temp[i] = temp[j];
                        temp[j] = tmp;
                    }
                }

            }
            foreach (var i in temp)
            {
                sorted.AddLast(i);
            }
            foreach(var member in sorted)
            {
                Console.Write(member+" ");
            }
        }


    }
    
}
