using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck
    {

        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for(int j = 0; j< 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //assigns the card a face based on the value of i
                    card.Suit = (Suit)j; //assigns the card a suit based on the value of j
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
