using System;
namespace FindMaximumNumberProject
{
    public class MaximumNumberCheck
    {
        private static readonly int thirdValue;

        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdvalue)

        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
            firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdvalue) > 0 ||
            firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdvalue) >= 0)
            {
                return firstValue;

            }

            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||

            secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
            secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }



            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||

            thirdvalue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||

            thirdvalue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return firstValue;

        }

    }

}