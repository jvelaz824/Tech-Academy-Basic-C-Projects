using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneRules
    {
        //creates a private dictionary of all cards and their values
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        //returns an int array of the possible values of a hand
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1]; //creates an array that's length is the count of aces in a hand + 1
            int value = Hand.Sum(x => _cardValues[x.Face]); //sums the value of each face in the list
            result[0] = value; //lowest value possible of cards
            if (result.Length == 1) return result; //if result.length is 1, there are no aces, return the result
            //if result.length is greater than 1, then there are aces, execute this for loop to determine their value
            for (int i = 1; i < result.Length; i++) 
            {
                value += (i * 10); 
                result[i] = value; 
            }
            return result;
        }

        //Method to check if a hand has blackjack 
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        //Method to check if a hand has busted
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); //gets the minimum value of cards in a hand
            if (value > 21) return true; //if it is greater than 21, bust, return true
            else return false;
        }

        //Method to determine if the dealer should stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) 
                {
                    return true; //dealer should stay
                }
            }
            return false;
        }

        
        //Method to compare the hand's of the player vs dealer
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand); //creates an array of the player's hand values
            int[] dealerResults = GetAllPossibleHandValues(PlayerHand); //creates an array of the dealers's hand values

            int playerScore = playerResults.Where(x => x < 22).Max(); //filter the values for the largest hand values that are still under 22
            int dealerScore = dealerResults.Where(x => x < 22).Max();//filter the values for the largest hand values that are still under 22
            if (playerScore > dealerScore) return true; //if player wins return true
            else if (playerScore < dealerScore) return false; //if dealer wins return false
            else return null; //if no one wins return null

        }
    }
}
