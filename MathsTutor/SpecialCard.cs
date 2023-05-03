using System;
namespace MathsTutor
{
    public class SpecialCard : Card
    {
        public SpecialCard(int value, char op) : base(value, GetSuitFromOperator(op))
        {
        }

        private static int GetSuitFromOperator(char op)
        {
            switch (op)
            {
                case '+':
                    return 0;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 3;
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }

        // Override the ToString method
        public override string ToString()
        {
            return $"{Value} {Operator}";
        }
    }
}

