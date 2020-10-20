using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class FindMaxNumber
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            try
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }
                throw new Exception("FirstNumber,SecondNumber and ThirdNumber are same");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught! " + e.Message);
                System.Environment.Exit(0);
                return 0;
            }
        }
        public static float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            try
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }
                throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught! " + e.Message);
                System.Environment.Exit(0);
                return 0;
            }
        }
    }
}
