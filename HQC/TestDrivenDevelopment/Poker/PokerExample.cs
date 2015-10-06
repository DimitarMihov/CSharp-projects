using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Console.WriteLine(hand);

            IHand flushHand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
            });
            Console.WriteLine(flushHand);

            IHand fourOfAKind = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            Console.WriteLine(fourOfAKind);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsFlush(flushHand));
            Console.WriteLine(checker.IsFourOfAKind(fourOfAKind));
            //Console.WriteLine(checker.IsOnePair(hand));
            //Console.WriteLine(checker.IsTwoPair(hand));
        }
    }
}
