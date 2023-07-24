using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class TwentyOneGame : Game, IWalkAway //inherits from Game and IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() 
        {
            Dealer = new TwentyOneDealer(); //instantiates new dealer
            foreach(Player player in Players) //Players is a list property in Game class
            {
                player.Hand = new List<Card>(); // gives players a new hand
                player.Stay = false;

            }
            Dealer.Hand = new List<Card>(); //gives dealer a new hand
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //gives dealer a new deck
            Dealer.Deck.Shuffle(); //shuffles the deck

            Console.WriteLine("Place your bet!"); //asks user to place their bet

            foreach (Player player in Players) //asks each Player in the list to place their bet
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if(!successfullyBet) //if successfullyBet is false
                {
                    return; //ends the method early if they do not have enough
                }

                Bets[player] = bet; //creates a dictionary of players & their bets (property in Game class)
            }

            //for loop to deal 2 cards to each player
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); //deals card to player
                    if(i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if(blackJack) //checks if player has blackjack
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            //player wins 1.5 times their bet plus their bet back
                            player.Balance = +Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }

                }

                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand); //deals cards to dealer
                if( i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); //checks if dealer has blackjack
                    if(blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance = +entry.Value; //adds the bet of each player to dealer's balance 
                        }
                        return;
                    }

                }
            }

            foreach(Player player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach(Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }

                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay")
                    {
                        player.Stay = true;
                        break; //breaks while loop 
                    }
                    else if(answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if(busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "ya")
                        {
                            player.isActivelyPlaying = true;
                            return;  //ends the void function & returns to while loop evaluating if player is actively playing
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return; //ends the void function & returns to while loop evaluating if player is actively playing
                        }

                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); //adds card to hand
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks for busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks for stay
            }
            if(Dealer.Stay)
            {
                Console.WriteLine("Dealer is Staying.");
            }
            if(Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //Players where their name matches an entry in the bets dictionary, adds their original bet + winnings (bet) to their balance
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                    return;
                }
            }

            //the following compares the players hand versus the dealers hand
            foreach(Player player in Players)
            {
                bool? playersWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playersWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //returns the bet to the player
                    Bets.Remove(player);
                    Console.WriteLine("Your current balance is: {0}", player.Balance); //displays current balance to player
                 }
                else if (playersWon == true)
                {
                    Console.WriteLine("{0 won {1}!", player.Name, Bets[player]); //displays how much the player won
                    player.Balance += (Bets[player] * 2); //adds player's winnings to their balance
                    Dealer.Balance -= Bets[player]; //subtracts player's winnings from dealer's balance
                    Console.WriteLine("Your current balance is: {0}", player.Balance); //displays current balance to player
                }
                else
                {
                    Console.WriteLine( "Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player]; //adds player's bet to the dealer balance
                    Console.WriteLine("Your current balance is: {0}", player.Balance); //displays current balance to player
                }
                Console.WriteLine("Play Again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "ya")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }

        }


        public override void ListPlayers()
        {
            Console.WriteLine("21 Payers:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }


    }

   
}
