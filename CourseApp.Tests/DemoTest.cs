using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(1, 1.107)]
        [InlineData(-100, 11.587)]
        [InlineData(100000, 318.382)]
        [InlineData(1.58, 0.98)]
        [InlineData(1 / 3.0, 0.259)]
        public void TestCalc(double x, double exp)
        {
            var result = Program.Calc(x);
            Assert.Equal(exp, result, 3);
        }

        [Fact]
        public void SizeTaskA()
        {
            var result = Program.TaskA(0, 1, 0.1);
            Assert.Equal(11, result.Length);
            double[] resultMassive = { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            for (int i = 0; i <= 10; i++)
            {
                var (x, y) = result[i];
                Assert.Equal(resultMassive[i], x, 1);
            }
        }

        [Fact]
        public void EmptyTaskA()
        {
            var result = Program.TaskA(10, 10, 1);
            var length1 = result.Length;
            Assert.Equal(1, length1);
        }

        [Fact]
        public void NegativeTaskA()
        {
            var result = Program.TaskA(12, 9, -1);
            Assert.Equal(4, result.Length);
            double[] resultMassive = { 12, 11, 10, 9 };
            for (int i = 4; i <= 0; i--)
            {
                var (x, y) = result[i];
                Assert.Equal(resultMassive[i], x, 1);
            }
        }

        [Fact]
        public void SizeTaskB()
        {
            double[] massive = { 1, 2, 3, 4 };
            var result = Program.TaskB(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                var (x, y) = result[i];
                Assert.Equal(massive[i], x, 1);
                Assert.Equal(Program.Calc(massive[i]), y, 1);
            }
        }

        [Fact]
        public void EmptyTaskB()
        {
            double[] massive = { };
            var result = Program.TaskB(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                var (x, y) = result[i];
                Assert.Equal(massive[i], x, 1);
                Assert.Equal(Program.Calc(massive[i]), y, 1);
            }
        }

        [Fact]
        public void NegativeTaskB()
        {
            double[] massive = { -10, -20, -30 };
            var result = Program.TaskB(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                var (x, y) = result[i];
                Assert.Equal(massive[i], x, 1);
                Assert.Equal(Program.Calc(massive[i]), y, 1);
            }
        }
    }
}
