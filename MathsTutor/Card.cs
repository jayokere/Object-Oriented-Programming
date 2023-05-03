using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    public interface ICard
    {
        int Value { get; }
        char Operator { get; }
    }

    public class Card : ICard
    {
        public int Value { get; private set; }
        public char Operator { get; private set; }

        public Card(int value, int suit)
        {
            Value = (value % 13);
            Operator = GetOperator(suit);
        }

        // Make GetOperator method protected
        protected char GetOperator(int suit)
        {
            switch (suit % 4)
            {
                case 0:
                    return '+';
                case 1:
                    return '-';
                case 2:
                    return '*';
                case 3:
                    return '/';
                default:
                    throw new ArgumentException("Invalid suit.");
            }
        }

        // Make ToString method virtual
        public override string ToString()
        {
            return $"{Value} {Operator}";
        }
        public int Suit { get; private set; }
    }
}
