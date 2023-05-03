using System;
namespace MathsTutor
{
    public class Pack
    {
        private List<Card> cards;
        private Random random = new Random();

        public Pack()
        {
            cards = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }
        public int Count => cards.Count;


        public virtual void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card Deal()
        {
            if (cards.Count == 0) throw new InvalidOperationException("No more cards in the pack.");
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public override string ToString()
        {
            return string.Join(", ", cards.Select(c => c.ToString()));
        }

    }

}

