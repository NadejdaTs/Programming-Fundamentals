using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Hands_of_Cards
{
    class HandsOfCards
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var cardsPower = CardPower();
            var cardsType = CardTypes();

            var cards = new Dictionary<string, HashSet<int>>();

            while (text != "JOKER")
            {
                var nameAndCards = text
                    .Split(':');

                var name = nameAndCards[0];
                var playerCards = nameAndCards[1]
                    .Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length -1);
                    var cardType = card.Substring(card.Length - 1);

                    var sum = cardsPower[cardPower] * cardsType[cardType];// ot promenlivite, koito izvikvat metodite

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }
                text = Console.ReadLine();               
            }
            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardsSum = pair.Value.Sum();

                Console.WriteLine($"{name}: {cardsSum}");
            }
        }

        private static Dictionary<string, int> CardPower()
        {
            var powers = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }

        private static Dictionary<string, int> CardTypes()
        {
            var types = new Dictionary<string, int>();

            types["S"] = 4;
            types["H"] = 3;
            types["D"] = 2;
            types["C"] = 1;

            return types;
        }    
    }
}
