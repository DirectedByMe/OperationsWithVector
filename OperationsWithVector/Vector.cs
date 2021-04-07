using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithVector
{
    public class Vector
    {
        public Vector(double x, double y, double z)
        {
            _x = x;

            _y = y;

            _z = z;
        }

        private readonly double _x = 0;
        public double X
        {
            get => _x;
        }

        private readonly double _y = 0;
        public double Y
        {
            get => _y;
        }

        private readonly double _z = 0;
        public double Z
        {
            get => _z;
        }

        public double LengthVector()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double ScalarVector(Vector vector)
        {
            return ((vector.X * X) + (vector.Y * Y) + (vector.Z * Z));
        }

        public Vector ProductionOfVectors(Vector vector)
        {
            double secondX = (vector.Y * Z - vector.Z * Y);

            double secondY = (vector.Z * X - vector.X * Z);

            double secondZ = (vector.X * Y - vector.Y * X);

            Vector firstVector = new (secondX, secondY, secondZ);

            return firstVector;
        }

        public double CosineVector(Vector vector)
        {
            double scalar = ScalarVector(vector);

            double firstLength = LengthVector();

            double secondLenght = vector.LengthVector();

            double cosine = scalar / (firstLength * secondLenght);

            return cosine;
        }

        public Vector SumVector(Vector vector)
        {
            Vector sum = new (vector.X + X, vector.Y + Y, vector.Z + Z);

            return sum;
        }

        public Vector DifferenceVector(Vector vector)
        {
            Vector diff = new (X - vector.X, Y - vector.Y, Z - vector.Z);

            return diff;
        }
    }
}

