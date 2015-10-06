using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardToStringTest
    {
        [TestMethod]
        public void AceHeartsToString_IsReturnedCorrectly()
        {
            Card aceHearts = new Card(CardFace.Ace, CardSuit.Hearts);

            Assert.AreEqual("A♥", aceHearts.ToString());
        }

        [TestMethod]
        public void ThreeHeartsToString_IsReturnedCorrectly()
        {
            Card threeHearts = new Card(CardFace.Three, CardSuit.Hearts);

            Assert.AreEqual("3♥", threeHearts.ToString());
        }

        [TestMethod]
        public void FourSpadesToString_IsReturnedCorrectly()
        {
            Card fourSpades = new Card(CardFace.Four, CardSuit.Spades);

            Assert.AreEqual("4♠", fourSpades.ToString());
        }

        [TestMethod]
        public void FiveSpadesToString_IsReturnedCorrectly()
        {
            Card fiveSpades = new Card(CardFace.Five, CardSuit.Spades);

            Assert.AreEqual("5♠", fiveSpades.ToString());
        }

        [TestMethod]
        public void SixDiamondsToString_IsReturnedCorrectly()
        {
            Card sixDiamonds = new Card(CardFace.Six, CardSuit.Diamonds);

            Assert.AreEqual("6♦", sixDiamonds.ToString());
        }

        [TestMethod]
        public void SevenDiamondsToString_IsReturnedCorrectly()
        {
            Card sevenDiamonds = new Card(CardFace.Seven, CardSuit.Diamonds);

            Assert.AreEqual("7♦", sevenDiamonds.ToString());
        }

        [TestMethod]
        public void EightClubsToString_IsReturnedCorrectly()
        {
            Card eightClubs = new Card(CardFace.Eight, CardSuit.Clubs);

            Assert.AreEqual("8♣", eightClubs.ToString());
        }

        [TestMethod]
        public void NineClubsToString_IsReturnedCorrectly()
        {
            Card nineClubs = new Card(CardFace.Nine, CardSuit.Clubs);

            Assert.AreEqual("9♣", nineClubs.ToString());
        }

        [TestMethod]
        public void TenClubsToString_IsReturnedCorrectly()
        {
            Card tenClubs = new Card(CardFace.Ten, CardSuit.Clubs);

            Assert.AreEqual("10♣", tenClubs.ToString());
        }

        [TestMethod]
        public void JackOfSpadesToString_IsReturnedCorrectly()
        {
            Card jackOfSpades = new Card(CardFace.Jack, CardSuit.Spades);

            Assert.AreEqual("J♠", jackOfSpades.ToString());
        }

        [TestMethod]
        public void KingDiamondsToString_IsReturnedCorrectly()
        {
            Card kingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);

            Assert.AreEqual("K♦", kingOfDiamonds.ToString());
        }

        [TestMethod]
        public void TwoOfClubsToString_IsReturnedCorrectly()
        {
            Card twoClubs = new Card(CardFace.Two, CardSuit.Clubs);

            Assert.AreEqual("2♣", twoClubs.ToString());
        }

        [TestMethod]
        public void QueenOfSpadesToString_IsReturnedCorrectly()
        {
            Card queenOfSpades = new Card(CardFace.Queen, CardSuit.Spades);

            Assert.AreEqual("Q♠", queenOfSpades.ToString());
        }
        
    }
}