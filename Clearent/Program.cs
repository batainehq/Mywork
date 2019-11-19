using System;
using System.Collections.Generic;

namespace Clearent
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstCase

            Console.WriteLine("The First Test Case :");


            // Create three instances of the card class (3 cedit cards)
            Card firstCard = new Card("Visa", 100);
            Card secondCard = new Card("MC", 100);
            Card thirdCard = new Card("Discover", 100);

            // add the cards to a list then add it to a wallet

            List<Card> cardList = new List<Card>();
            cardList.Add(firstCard);
            cardList.Add(secondCard);
            cardList.Add(thirdCard);

            Wallet wallet = new Wallet(cardList);
            
            // Create a wallet list of one wallet then ad it to a person Class (this person has only one wallet)
            List<Wallet> walletList = new List<Wallet>();
            walletList.Add(wallet);

            Person person = new Person(walletList);

            // calculate the total amout for this person
            float amout = person.CalculatePersonInterestAmt();
            Console.WriteLine("The total interest (simple interest) for this person = {0}", amout);

            // use nested loop to loop thru all wallets and cards 
            int counter = 1;
            foreach (var val in person.WalletsList)
            {
                Console.WriteLine("------ Wallet number {0} ------", counter);
                foreach (var item in val.CardsList)
                {
                    Console.WriteLine("{0} card interest amout = {1}", item.Type, item.CalculateCardInterestAmt());

                }
                counter++;
            }
            #endregion

            #region SecondCase

            Console.WriteLine("\n" + "The Second Test Case :");


            // Create two instances of the card class (2 cedit cards)
            Card cardFirst = new Card("Visa", 100);
            Card cardSecond = new Card("Discover", 100);

            // add the cards to a list then add it to the first wallet

            List<Card> cardsList = new List<Card>();
            cardsList.Add(cardFirst);
            cardsList.Add(cardSecond);
            Wallet firstWallet = new Wallet(cardsList);

            // Create one instance of the card class (1 cedit cards)
            Card cardThird = new Card("MC", 100);

            // add the card to a list of one card ( only one card in the second wallet) then add it to the second wallet
            List<Card> secondCardsList = new List<Card>();
            secondCardsList.Add(cardThird);
            Wallet secondtWallet = new Wallet(secondCardsList);


            //// Create a wallet list of two  wallets  (this person has two wallets) then add it to a person Class
            List<Wallet> walletslist = new List<Wallet>();
            walletslist.Add(firstWallet);
            walletslist.Add(secondtWallet);

            Person person1 = new Person(walletslist);

            // calculate the total amout for this person
            Console.WriteLine("The total interest (simple interest) for this person = {0}", person1.CalculatePersonInterestAmt());

            // use loop to go thru all wallets  
            int number = 1;
            foreach (var val in person1.WalletsList)
            {
                Console.WriteLine("Wallet number {0} total interest amout = {1}", number, val.CalculateWalletInterestAmt());

                number++;
            }
            #endregion


            #region ThirdCase

            Console.WriteLine("\n" + "The Third Test Case :");

            #region FirstPerson
            // for the first person, Create three instances of the card class (3 cedit cards)
            Card cardFi = new Card("Visa", 100);
            Card cardSe = new Card("Discover", 100);
            Card cardTh = new Card("MC", 100);

            // add the cards to a list then add it to the wallet
            List<Card> fitsrCardsList = new List<Card>();
            fitsrCardsList.Add(cardFi);
            fitsrCardsList.Add(cardSe);
            fitsrCardsList.Add(cardTh);
            Wallet walletFirst = new Wallet(fitsrCardsList);

            // create a list of wallets (one element list as this person has one wallet only) then add it to  person class
            List<Wallet> firstWalletslist = new List<Wallet>();
            firstWalletslist.Add(walletFirst);
            Person personFirst = new Person(firstWalletslist);
                                 
            // calculate the total amout for this person
            Console.WriteLine("The total interest (simple interest) for the first person = {0}", personFirst.CalculatePersonInterestAmt());

            // use loop to go thru all wallets  
            int count = 1;
            foreach (var val in personFirst.WalletsList)
            {
                Console.WriteLine("Wallet number {0} total interest amout = {1}", count, val.CalculateWalletInterestAmt());
                count++;
            }

            #endregion

            #region SecondPerson

            // for the Second person, Create two instances of the card class (2 cedit cards)
            Card cardFir = new Card("Visa", 100);
            Card cardSec = new Card("MC", 100);

            // add the cards to a list then add it to the wallet
            List<Card> firCardsList = new List<Card>();
            firCardsList.Add(cardFir);
            firCardsList.Add(cardSec);
            Wallet walletSecond = new Wallet(firCardsList);

            // create a list of wallets (one element list as this person has one wallet only) then add it to  person class
            List<Wallet> secondWalletslist = new List<Wallet>();
            secondWalletslist.Add(walletSecond);
            Person personSecond = new Person(secondWalletslist);

            // calculate the total amout for this person
            Console.WriteLine("The total interest (simple interest) for the Second person = {0}", personSecond.CalculatePersonInterestAmt());

            // use loop to go thru all wallets  
            int coun = 1;
            foreach (var val in personSecond.WalletsList)
            {
                Console.WriteLine("Wallet number {0} total interest amout = {1}", coun, val.CalculateWalletInterestAmt());
                coun++;
            }

            #endregion
            #endregion
        }
    }
}
