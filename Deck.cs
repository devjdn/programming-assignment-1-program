using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaydensApp
{
    internal class Deck
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

        public void Add(PlayingCard cardToAdd)
        {
            _Cards.Add(cardToAdd);
        } // End Add method

        public Deck()
        {
            _Cards = new List<PlayingCard>();
            foreach(String suit in PlayingCard.Suits)
                foreach(String face in PlayingCard.Faces)
                    _Cards.Add(new PlayingCard(suit, face));

            Shuffle();
        } // End of Deck constructor method

        private void Shuffle()
        {
            List<PlayingCard> newDeck = new List<PlayingCard>();

            while(_Cards.Count > 0)
            {
                int cardToMove = rndNum.Next(_Cards.Count);
                newDeck.Add(_Cards[cardToMove]);
                _Cards.RemoveAt(cardToMove);
            }

            _Cards = newDeck;
        } // End of Shuffle method

        public PlayingCard Deal()
        {
            PlayingCard cardToDeal = _Cards[0];
            _Cards.RemoveAt(0);
            return cardToDeal;
        } // End of Deal method

        private Random rndNum = new Random(Guid.NewGuid().GetHashCode());

    } // End of Deck Class
}
