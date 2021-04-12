using System;
using Xunit;
namespace OperationsWithVector.Test
{
    public class UnitTestOperationsWithVector
    {
        [Fact]
        public void LengthVectorTest()
        {
            var vec1 = new Vector(6.0, 11.0, 9.0);

            double result = vec1.LengthVector();

            Assert.Equal(15.427, result, 3);
        }
        [Fact]
        public void ScalarVectorTest()
        {
            var vec1 = new Vector(4.0, 7.0, 12.0);
            var vec2 = new Vector(15.0, 8.0, 5.0);

            double result = vec1.ScalarVector(vec2);

            Assert.Equal(176, result);
        }
    }
}