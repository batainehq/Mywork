using System;
using System.Collections.Generic;
using System.Text;

namespace Clearent
{
    class Person
    {
        List<Wallet> _walletsList = new List<Wallet>();

        public List<Wallet> WalletsList
        {
            get { return _walletsList; }
            set { _walletsList = value; }
        }

        public Person(List<Wallet> listofWallets)
        {
            this.WalletsList = listofWallets;
        }


        public float CalculatePersonInterestAmt()
        {
            float Intersets = 0;
            foreach (var item in this.WalletsList)
            {
                Intersets += item.CalculateWalletInterestAmt();
            }
            return Intersets;
        }
    }
}
