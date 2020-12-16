using NUnit.Framework;
using CodingChallenge;
using System;

namespace UnitTestProject
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Assert_RotatedArray()
        {
            int[,] array = new int[2, 2] { { 0, 1 }, { 2, 3 } };
            int[,] expected = new int[2, 2] { { 2, 0 }, { 3, 1 } };
            Program objProgram = new Program();
            int[,] outputArray = objProgram.RotateArray(2, 2, array);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], outputArray[i, j]);
                }
            }
        }
        [Test]
        public void Assert_RotateArray_ThrowError()
        {
            int[,] array = new int[2, 2] { { 0, 1 }, { 2, 3 } };
            int[,] expected = new int[2, 2] { { 2, 0 }, { 3, 1 } };
            Program objProgram = new Program();
            Assert.Throws<IndexOutOfRangeException>(() => objProgram.RotateArray(2, 3, array));
        }
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        public void Assert_RotateArrayWidthHeight(int width,int height)
        {
            int[,] array = new int[2, 2] { { 0, 1 }, { 2, 3 } };
            int[,] expected = new int[width, height];
            Program objProgram = new Program();
            int[,] outputArray = objProgram.RotateArray(width, height, array);
            Assert.AreEqual(expected, outputArray);
        }
        [TestCase(-1, 2)]
        [TestCase(2, -1)]
        public void Assert_RotateArrayNegativeWidthHeight(int width, int height)
        {
            int[,] array = new int[2, 2] { { 0, 1 }, { 2, 3 } };
            Program objProgram = new Program();
            Assert.Throws<IndexOutOfRangeException>(() => objProgram.RotateArray(2, 3, array));
        }
    }
}