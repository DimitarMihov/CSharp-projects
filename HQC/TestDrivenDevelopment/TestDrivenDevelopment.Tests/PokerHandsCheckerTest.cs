using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ValidateZeroCards_ThrowException()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            checker.IsValidHand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateOneCards_ThrowException()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
            });

            PokerHandsChecker checker = new PokerHandsChecker();
            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void ValidateTwoCards_IsFalse()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            PokerHandsChecker checker = new PokerHandsChecker();
            
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void ValidateFiveDifferentCards_IsTrue()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void ValidateFiveCards_WithTwo_SameOfSuitCards_IsFalse()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        //before validating the flush - the hand is validated by IsValidHand - that's why i don't redo same tests
        [TestMethod]
        public void FlushNonValideHand_IsFalse()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }
        
        [TestMethod]
        public void FlushValidateFiveDifferentCards_IsFalse()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void FlushValidateFiveDifferentFromSameSuit_IsTrue()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        //before validating the four of a kind - the hand is validated by IsValidHand - that's why i don't redo same tests
        [TestMethod]
        public void FourOfAKindNonValidHand_IsFalse()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void FourOfAKindValidateFiveDifferentCards_IsFalse()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void FourOfAKindFiveCards_FourWithSameFace_IsTrue()
        {
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
            });

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }
    }
}