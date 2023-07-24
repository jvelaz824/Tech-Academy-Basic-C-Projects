using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class Card
    {
        public Card() //this is a constructor aka function. Needs to be the name of the class. These are default values if none are assigned later
        {
            Suit = "Spades";
            Face = "True";
        }
        public string Suit { get; set; } //creates the property and degines what functions you can do with it
        public string Face { get; set; }

    }
}
