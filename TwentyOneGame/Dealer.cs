using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //First takes the first item in that list - so adding the first card of the deck to the hand to deal
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //writes the card at the top of the deck to a string variable
            //the following writes the dealt card to the text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\jocelynv\Documents\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }

            Console.WriteLine(card); //prints the card to the console
            Deck.Cards.RemoveAt(0); //remove the first item of the deck (the card we just printed) so it can no longer be used
        }
    }
}
