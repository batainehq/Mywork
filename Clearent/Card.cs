using System;
using System.Collections.Generic;
using System.Text;

namespace Clearent
{
    class Card
    {
        string _type { get; set; }
        float _rate { get; set; }
        float _balance { get; set; }

        public string Type
        {
            get { return _type; }

            set { _type = value; }
        }
        public float Rate
        {
            get { return _rate; }

            set { _rate = value; }
        }
        public float Balance
        {

            get { return _balance; }

            set { _balance = value; }
        }


        public Card(string type, float amount)
        {
            this.Type = type;
            this.Balance = amount;

            if (type == "Visa")
            {
                this.Rate = 10 / 100f;
            }

            if (type == "MC")
            {
                this.Rate = 5 / 100f;
            }

            if (type == "Discover")
            {
                this.Rate = 1 / 100f;
            }


        }

        public float CalculateCardInterestAmt()
        {
            float Intersets = 0;
            if (this.Type == "Visa" || this.Type == "MC" || this.Type == "Discover")
            {
                Intersets = (this.Balance * this.Rate * 1);
            }

            return Intersets;

        }











    }
}
