using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numero complesso 1:");
            Complex c1 = Complex.Parse(Console.ReadLine());
            Console.WriteLine("numero complesso 2:");
            Complex c2=Complex.Parse(Console.ReadLine());
            Console.WriteLine("numero scalare:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("somma: {0}", c1 + c2);
            Console.WriteLine("differenza: {0}", c1 - c2);
            Console.WriteLine("prodotto 1: {0}", c1 * c2);
            Console.WriteLine("prodotto 2: {0}", c1 * x);
            Console.WriteLine("divisione: {0}", c1 / x);
            if (c1 == c2)
            {
                Console.WriteLine("uguali");
            }
            else
            {
                Console.WriteLine("diversi");
            }
            Complex c = new Complex(c1.A, c1.B);
            Complex d = new Complex(c2.A, c2.B);
            Console.WriteLine("modulo c1: {0}", c1.Modulo());
            Console.WriteLine("modulo c2: {0}", c2.Modulo());
            Console.WriteLine("angolo c1: {0}", c1.Angolo());
            Console.WriteLine("angolo c2: {0}", c2.Angolo());
            Console.ReadLine();
        }
    }
}
