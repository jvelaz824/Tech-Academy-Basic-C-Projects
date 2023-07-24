﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public struct Card
    {

        public Suit Suit { get; set; } //creates a Suit property
        public Face Face { get; set; } //creates a Face property

        public override string ToString() //prints out the cards value
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
}