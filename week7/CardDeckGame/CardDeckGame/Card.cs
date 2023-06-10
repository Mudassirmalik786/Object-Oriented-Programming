using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckGame
{
    class Card
    {
        private int value;
        private int suite;
        public Card(int value, int suite)
        {
            this.value = value;
            this.suite = suite;
        }
        public int getValue()
        {
            return value;
        }
        public int getSuit()
        {
            return suite;
        }
        public string getValueAsString()
        {
            if(value == 1)
            {
                return "Ace";
            }
            else if(value == 11)
            {
                return "Jack";
            }
            else if(value == 12)
            {
                return "Queen";
            }
            else if(value == 13)
            {
                return "King";
            }
            else
            {
                return value.ToString();
            }
        }
        public string getSuitAsString()
        {
            if(suite == 1)
            {
                return "Clubs";
            }
            else if (suite == 2)
            {
                return "Diamonds";
            }
            else if (suite == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
        }
        public string toString()
        {
            return getValueAsString() + " of " + getValueAsString();
        }
    }
}
