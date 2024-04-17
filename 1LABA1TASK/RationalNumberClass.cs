using System;

 public class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            _numerator = numerator;
            _denominator = denominator;
            Simplify();
        }

        public override string ToString()
        {
            if (_denominator == 1)
                return _numerator.ToString();
            return $"{_numerator}/{_denominator}";
        }

        public static RationalNumber operator +(RationalNumber item, RationalNumber item2)
        {
            int numerator = item._numerator * item2._denominator + item2._numerator * item._denominator;
            int denominator = item._denominator * item2._denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator -(RationalNumber item, RationalNumber item2)
        {
            int numerator = item._numerator * item2._denominator - item2._numerator * item._denominator;
            int denominator = item._denominator * item2._denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator *(RationalNumber item, RationalNumber item2)
        {
            int numerator = item._numerator * item2._numerator;
            int denominator = item._denominator * item2._denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator /(RationalNumber item, RationalNumber item2)
        {
            if (item2._numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            int numerator = item._numerator * item2._denominator;
            int denominator = item._denominator * item2._numerator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator -(RationalNumber item)
        {
            return new RationalNumber(-item._numerator, item._denominator);
        }

        public static bool operator ==(RationalNumber item, RationalNumber item2)
        {
            return item._numerator * item2._denominator == item2._numerator * item._denominator;
        }

        public static bool operator !=(RationalNumber item, RationalNumber item2)
        {
            return !(item == item2);
        }

        public static bool operator <(RationalNumber item, RationalNumber item2)
        {
            return item._numerator * item2._denominator < item2._numerator * item._denominator;
        }

        public static bool operator >(RationalNumber item, RationalNumber item2)
        {
            return item._numerator * item2._denominator > item2._numerator * item._denominator;
        }

        public static bool operator <=(RationalNumber item, RationalNumber item2)
        {
            return item._numerator * item2._denominator <= item2._numerator * item._denominator;
        }

        public static bool operator >=(RationalNumber item, RationalNumber item2)
        {
            return item._numerator * item2._denominator >= item2._numerator * item._denominator;
        }

        private void Simplify()
        {
            int gcd = GCD(_numerator, _denominator);
            _numerator /= gcd;
            _denominator /= gcd;

            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }