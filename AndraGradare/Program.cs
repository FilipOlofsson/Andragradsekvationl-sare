using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndraGradare
{
    class Program
    {

        static double a, b, c, x1, x2;

        static void Main(string[] args) {
        
            while(true)
            {
                Console.WriteLine("Useage: This can only be used for second degree equations. (Example: x^2 + 3x - 4 = 0)");
                Console.WriteLine("What is your a value using this? ax2 + bx + c = 0");
                a = Double.Parse(Console.ReadLine()); //C# verkar inte gilla Console.Read så mycket så jag läser den som en string som jag konverterar till en double.
                Console.WriteLine("And your b value?");
                b = Double.Parse(Console.ReadLine()); //C# verkar inte gilla Console.Read så mycket så jag läser den som en string som jag konverterar till en double.
                Console.WriteLine("And your c value?");
                c = Double.Parse(Console.ReadLine()); //C# verkar inte gilla Console.Read så mycket så jag läser den som en string som jag konverterar till en double.
                Console.WriteLine("Calculating...");
                Console.WriteLine("\n");
                Console.WriteLine("x1 = "+ CalculateX1(a, b, c));
                if(CalculateX1(a, b, c) != CalculateX2(a, b, c))
                    Console.WriteLine("x2 = " + CalculateX2(a, b, c));
                Console.WriteLine("Please note, these might not be a real value.");
                Console.WriteLine("\n");
            }
        }
        static double CalculateX1(double a, double b, double c)
        {
            x1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a); //Formeln för att räkna ut en av rötterna på en andragradsekvation
            return x1;
        }
        static double CalculateX2(double a, double b, double c)
        {
            x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a); //Formeln för att räkna ut den andra roten
            return x2;
        }
    }
}


/*ATT FÖRBÄTTRA
 * Kolla rötter
 * Den får i nuläget bara ut reella svar.
 */