using System;
using System.Collections.Generic;
using System.Text;

namespace Clearent
{
    class Wallet
    {
        List<Card> _cardsList = new List<Card>();

        
        public List<Card> CardsList
        {
            get { return _cardsList; }
            set { _cardsList = value; }
        }

        public Wallet(List<Card> listofCards)
        {
            this.CardsList = listofCards;
        }


        public float CalculateWalletInterestAmt()
        {
            float Intersets = 0;
            foreach(var item in this.CardsList)
            {
                Intersets += item.CalculateCardInterestAmt();
            }

            return Intersets;
        }
    }
}
