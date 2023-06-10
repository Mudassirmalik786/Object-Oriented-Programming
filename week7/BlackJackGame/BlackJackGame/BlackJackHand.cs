using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class BlackJackHand : Hand
    {
        private string person;
        public int getBlackJackValue()
        {
            ace = false;
            cards = cardsLeft();
            if (person == "King" || person == "Queen" || person == "Jack")
            {
                value = 10;
            }
            else
            {
                value = 11;
            }
            return value;
        }
        private int cardsLeft()
        {
            throw new NotImplementedException();
        }
    }
}
