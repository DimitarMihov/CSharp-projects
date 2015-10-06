using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const byte ValidHandCount = 5;

        public bool IsValidHand(IHand hand)
        {
            String[] splitedHand = hand.ToString().Split(' ');

            if (splitedHand.Length != ValidHandCount)
            {
                return false;
            }

            for (int i = 0,len = splitedHand.Length; i < len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (splitedHand[i] == splitedHand[j])
                    {
                        return false;
                    }
                }  
            }

            return true;
        }

        //was missing -- added
        public bool IsRoyalFLush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            int faceCounter = 1;
            int maxCounter = 0;
            String[] splitedHand = hand.ToString().Split(' ');

            for (int i = 0, len = splitedHand.Length; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (splitedHand[i][0] == splitedHand[j][0])
                    {
                        faceCounter++;
                    }
                }

                if (faceCounter > maxCounter)
                {
                    maxCounter = faceCounter;
                    faceCounter = 1;
                }
            }
            
            if (maxCounter == 4)
                return true;
            else
                return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if(!IsValidHand(hand))
            {
                return false;
            }

            String[] splitedHand = hand.ToString().Split(' ');

            for (int i = 0, len = splitedHand.Length; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (splitedHand[i][1] != splitedHand[j][1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
