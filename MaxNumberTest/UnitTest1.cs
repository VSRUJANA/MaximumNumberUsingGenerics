using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumber;

namespace MaxNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        //Test methods for MaximumIntegerNumber method

        [TestMethod]
        [DataRow(9, 4, 1)]
        [DataRow(413, 312, 101)]
        public void Given_Max_IntegerNumber_At_First_Position_Return_Max(int num1, int num2, int num3)
        {
            int result = FindMaxNumber.MaximumIntegerNumber(num1, num2, num3);
            int expected = num1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9, 23, 1)]
        [DataRow(143, 165, 11)]
        public void Given_Max_IntegerNumber_At_Second_Position_Return_Max(int num1, int num2, int num3)
        {
            int result = FindMaxNumber.MaximumIntegerNumber(num1, num2, num3);
            int expected = num2;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9, 4, 43)]
        [DataRow(43, 32, 185)]
        public void Given_Max_IntegerNumber_At_Third_Position_Return_Max(int num1, int num2, int num3)
        {
            int result = FindMaxNumber.MaximumIntegerNumber(num1, num2, num3);
            int expected = num3;
            Assert.AreEqual(expected, result);
        }

        //Test methods for MaximumFloatNumber method

        [TestMethod]
        [DataRow(9.32f, 4.43f, 1.72f)]
        [DataRow(413.54f, 312.8f, 101.59f)]
        public void Given_Max_FloatNumber_At_First_Position_Return_Max(float num1, float num2, float num3)
        {
            float result = FindMaxNumber.MaximumFloatNumber(num1, num2, num3);
            float expected = num1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9.56f, 23.4f, 1.94f)]
        [DataRow(143.3f, 165.87f, 11.9f)]
        public void Given_Max_FloatNumber_At_Second_Position_Return_Max(float num1, float num2, float num3)
        {
            float result = FindMaxNumber.MaximumFloatNumber(num1, num2, num3);
            float expected = num2;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9.44f, 4.49f, 43.4f)]
        [DataRow(43.52f, 32f, 185.46f)]
        public void Given_Max_FloatNumber_At_Third_Position_Return_Max(float num1, float num2, float num3)
        {
            float result = FindMaxNumber.MaximumFloatNumber(num1, num2, num3);
            float expected = num3;
            Assert.AreEqual(expected, result);
        }
    }
}
