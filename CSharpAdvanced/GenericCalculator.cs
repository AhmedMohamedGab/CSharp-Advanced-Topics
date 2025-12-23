using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CSharpAdvanced
{
    internal class GenericCalculator<T> where T : struct, INumber<T>
    {
        public T Add(T num1, T num2) => num1 + num2;

        public T Subtract(T num1, T num2) => num1 - num2;

        public T Multiply(T num1, T num2) => num1 * num2;
        public T Divide(T num1, T num2)
        {
            if (num2 == T.Zero)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return num1 / num2;
        }
    }
}
