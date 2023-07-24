using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>() {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {

                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) // times = 1 makes the second paramater optional (meanining it does not have to be included), if it is not, it will just default to 1
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random(); //Random is library function to randomize an outcome

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //to shuffle between 0 and 52
                    TempList.Add(Cards[randomIndex]); //adding random card to temp deck that holds shuffled cards
                    Cards.RemoveAt(randomIndex); //removes card that has been added so it cannot be readded
                }

                Cards = TempList;

            }
            
        }
    }
}
