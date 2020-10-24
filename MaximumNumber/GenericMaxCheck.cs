using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class GenericMaxCheck<T> where T : IComparable
    {
        public T firstValue;
        public T secondValue;
        public T thirdValue;

        public GenericMaxCheck(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public T MaximumCheck()
        {
            try
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
                {
                    return this.firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                    secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                    secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
                {
                    return this.secondValue;
                }
                if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
                    thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
                    thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
                {
                    return this.thirdValue;
                }
                throw new Exception("first value,second value and third value are same");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                System.Environment.Exit(0);
                return this.firstValue;
            }
        }

        public void PrintMaxValue()
        {
            var output = MaximumCheck();
            Console.WriteLine("Maximum value: " + output);
        }
    }
}
