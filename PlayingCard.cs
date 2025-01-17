﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaydensApp
{
    internal class PlayingCard
    {

        static public string[] Suits = { "Spades", "Clubs", "Diamonds", "Hearts" }; // Defines and array of suits
        static public string[] Faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" }; // Defines an array of Faces

        public String Suit { get; set; }

        public String Face { get; set; }

        public int Value { get; set; }


        /// <summary>
        /// PlayingCard constructor that takes in two parameters
        /// Those being: inSuit, and inFace
        /// </summary>
        /// <param name="inSuit"></param>
        /// <param name="inFace"></param>
        public PlayingCard(String inSuit, String inFace)
        {
            Suit = inSuit;
            Face = inFace;

            switch (inFace)
            {
                case "Ace":
                    Value = 11; // Default to 11 for Blackjack; adjust dynamically based on hand value later.
                    break;
                case "Two":
                    Value = 2;
                    break;
                case "Three":
                    Value = 3;
                    break;
                case "Four":
                    Value = 4;
                    break;
                case "Five":
                    Value = 5;
                    break;
                case "Six":
                    Value = 6;
                    break;
                case "Seven":
                    Value = 7;
                    break;
                case "Eight":
                    Value = 8;
                    break;
                case "Nine":
                    Value = 9;
                    break;
                case "Ten":
                case "Jack":
                case "Queen":
                case "King":
                    Value = 10; // Face cards all have a value of 10 in Blackjack.
                    break;

                default:
                    throw new ArgumentException("Invalid card face value.");
            }
        } // End of PlayingCard constructor method

        public override string ToString()
        {
            return $"Suit {Suit}, Face {Face}, Value {Value}";
        }
    }
}
