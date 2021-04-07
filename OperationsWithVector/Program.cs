using System;

namespace OperationsWithVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector firstVector = new Vector(12, 5, 1);

            Vector secondVector = new Vector(9, 3, 15);

            var length = firstVector.LengthVector();

            Console.WriteLine($"Vector LEngth = {length}");

            var scalar = firstVector.ScalarVector(secondVector);

            Console.WriteLine($"Dot product of vectors = {scalar}");

            var production = firstVector.ProductionOfVectors(secondVector);

            Console.WriteLine($"Vector product with another vector:\nY/Z: {production.X};\nZ/X: {production.Y};\nX/Y: {production.Z};");

            var cosine = firstVector.CosineVector(secondVector);

            Console.WriteLine($"Cosine of vectors = {cosine}");

            var sum = firstVector.SumVector(secondVector);

            Console.WriteLine($"Sum of Vectors:\nX: {sum.X};\nY: {sum.Y};\nZ: {sum.Z};");

            var difference = firstVector.DifferenceVector(secondVector);

            Console.WriteLine($"Difference of Vectors:\nX: {difference.X};\nY: {difference.Y};\nZ: {difference.Z};");

            Console.ReadLine();
        }
    }
}
