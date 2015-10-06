using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class HandToStringTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void EmptyHand_ThrowException()
        {
            new Hand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullHandGiven_ThrowException()
        {
            new Hand(new List<ICard>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OneCardHand_ThrowException()
        {
            new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MoreThanFiveCardsInHand_ThrowException()
        {
            new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
            });
        }

        [TestMethod]
        public void TwoCardHandToString()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
            });

            string result = hand.ToString();

            Assert.AreEqual("A♠ A♥", result);
        }

        [TestMethod]
        public void TwoSameCardHandToString()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
            });

            string result = hand.ToString();

            Assert.AreEqual("A♠ A♠", result);
        }

        [TestMethod]
        public void FiveCardHandToString()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
            });

            string result = hand.ToString();

            Assert.AreEqual("A♠ A♦ A♣ A♥ J♠", result);
        }
    }
}