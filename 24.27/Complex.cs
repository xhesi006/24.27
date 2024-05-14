using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._27
{
    internal class Complex
    {
        private readonly double _A;
        private readonly double _B;
        public double A { get { return _A; } }
        public double B { get { return _B; } }
        public Complex(double a, double b)
        {
            _A = a;
            _B = b;
        }
        public static Complex Parse(string str)
        {
            string[] componenti = str.Split(',');
            return new Complex(double.Parse(componenti[0]), double.Parse(componenti[1]));

        }
        public override string ToString()
        {
            return string.Format("{0} + {1} i", A, B);
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.A + c2.A, c1.B + c2.B);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.A - c2.A, c1.B - c2.B);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.A * c2.A - c1.B * c2.B, c1.A * c2.B + c1.B * c2.A);
        }
        public static Complex operator *(Complex c1, double x)
        {
            return new Complex(c1.A * x, c1.B * x);
        }
        public static Complex operator /(Complex c1, double x)
        {
            return new Complex(c1.A / x, c1.B / x);
        }
        public static bool operator ==(Complex c1, Complex c2)
        {
            if (object.ReferenceEquals(c1, null) && object.ReferenceEquals(c2, null))
            {
                return true;
            }
            if(object.ReferenceEquals(c1,null) || object.ReferenceEquals(c2, null))
            {
                return false;
            }
            return (c1.A == c2.A && c1.B == c2.B);
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }
        public double Modulo()
        {
            return Math.Sqrt(A * A + B * B);
        }
        
        public double Angolo()
        {
            return (Math.Atan(B / A)) * 180 / Math.PI;
        }
    }
}
