using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            if (cards.Count == 0)
            {
                throw new NullReferenceException("Empty or null card set is given.");
            }

            if (cards.Count == 1)
            {
                throw new ArgumentOutOfRangeException("Cards must be above count of two(2).");
            }

            if (cards.Count > 5)
            {
                throw new ArgumentOutOfRangeException("Cards must be below count of five(5) including.");
            }

            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (ICard card in this.Cards)
            {
                result.Append(card.ToString() + new string(' ',1));
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
    }
}
