using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaydensApp
{
    /// <summary>
    /// This class contains all methods and properties regarding a player's hand
    /// </summary>
    internal class Hand
    {
        private List<PlayingCard> _Cards;

        public List<PlayingCard> Cards
        {
            get { return _Cards; }
        }

        public int Count
        {
            get { return _Cards.Count; }
        }

        public Hand()
        {
            _Cards = new List<PlayingCard>();
        } // End of Hand constructor

        public void AddCardToHand(PlayingCard cardToAdd)
        {
            _Cards.Add(cardToAdd);
        } // End of AddCardToHand method

        public int GetHandValue()
        {
            int cardValue = 0;
            int handValue = 0;
            int aceCount = 0;

            for(int ptr = 0; ptr < _Cards.Count; ptr++)
            {
                if(_Cards[ptr].Value > 10)
                {
                    cardValue = 10;
                } else if (_Cards[ptr].Face == "Ace")
                {
                    cardValue = 11;
                    aceCount++;
                }

                handValue = handValue + cardValue;
            }

            while((handValue > 21) && (aceCount > 0))
            {
                
            }

            return handValue;
        } // End of GetHandValue method
    }
}
