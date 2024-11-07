namespace Section1._2
{
    internal class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        private Rational(int numerator, int denominator)
        {
            Denominator = denominator;
            Numerator = numerator;
        }

        public static Rational? CreateRational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Denominator must not be 0");
                return null;
            }
            return new Rational(numerator, denominator);
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (a % b != 0)
            {
                return GreatestCommonDivisor(b, a % b);
            }
            return b;
        }
        public static Rational SimplifyFraction(Rational r)
        {
            if (GreatestCommonDivisor(r.Numerator, r.Denominator) == 0) return r;
            if (GreatestCommonDivisor(r.Numerator, r.Denominator) != 1)
            {
                r.Numerator /= GreatestCommonDivisor(r.Numerator, r.Denominator);
                r.Denominator /= GreatestCommonDivisor(r.Numerator, r.Denominator);
            }
            return r;
        }

        public Rational Plus(Rational b)
        {
            int newNumerator = Numerator * b.Denominator + b.Numerator * Denominator;
            int newDenominator = Denominator * b.Denominator;

            Rational? result = CreateRational(newNumerator, newDenominator);
            SimplifyFraction(result);
            return result;

        }
        public Rational Minus(Rational b)
        {
            int newNumerator = Numerator * b.Denominator - b.Numerator * Denominator;
            int newDenominator = Denominator * b.Denominator;

            Rational? result = CreateRational(newNumerator, newDenominator);
            SimplifyFraction(result);
            return result;

        }

        public Rational Times(Rational b)
        {
            int newNumerator = Numerator * b.Numerator;
            int newDenominator = Denominator * b.Denominator;

            Rational? result = CreateRational(newNumerator, newDenominator);
            SimplifyFraction(result);
            return result;
        }

        public Rational DividedBy(Rational b)
        {
            Rational? InversedRational = CreateRational(b.Denominator, b.Numerator);
            Rational result = Times(InversedRational);
            return result;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override bool Equals(object? that)
        {
            if (that is null) return false;
            if (that is not Rational thatRational) return false;

            return Numerator == thatRational.Numerator && Denominator == thatRational.Denominator;
        }




    }
}

