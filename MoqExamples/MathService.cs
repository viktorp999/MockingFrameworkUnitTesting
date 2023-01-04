using System;

namespace MoqExamples
{
    public class MathService : IMathService
    {
        public int MathMethod(int input)
        {
            switch (input)
            {
                case 1:
                    throw new ArgumentException();

                case 2:
                    throw new DivideByZeroException();

                case 3:
                    throw new InvalidCastException();

                default:
                    return input * 2;
            }
        }
    }
}
