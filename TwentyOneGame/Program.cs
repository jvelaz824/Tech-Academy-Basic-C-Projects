using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //creates new deck

            deck.Shuffle(3); //calls the method shuffle, and has it shuffle the deck 3 times



            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

       

        

        

    }
}
