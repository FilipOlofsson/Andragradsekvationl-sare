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

        static void Main(string[] args)
        {
            Console.WriteLine("Useage: This can only be used for second degree equations. (Example: x^2 + 3x - 4 = 0)");
            Console.WriteLine("What is your a value using this? ax2 + bx + c = 0");
            a = Double.Parse(Console.ReadLine()); //C# verkar inte gilla Console.Read så mycket så jag läser den som en string som jag konverterar till en double.
            Console.WriteLine("And your b value?");
            b = Double.Parse(Console.ReadLine()); //C# verkar inte gilla Console.Read så mycket så jag läser den som en string som jag konverterar till en double.
            Console.WriteLine("And your c value?");
            c = Double.Parse(Console.ReadLine()); //C# verkar inte gilla Console.Read så mycket så jag läser den som en string som jag konverterar till en double.
            Console.WriteLine("Calculating...");
            CalculateX(a, b, c);

        }
        static void CalculateX(double a, double b, double c)
        {
            x1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a; //Formeln för att räkna ut en av rötterna på en andragradsekvation 
            x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a; //Formeln för att räkna ut den andra roten
            Console.WriteLine("x1 = " + x1 +"\nx2 = "+x2); //Skriv ut rötterna
            Console.WriteLine("Remember to check for false roots."); //Vi kollar inte om alla rötter stämmer
            Console.Read();
        }
    }
}


/*ATT FÖRBÄTTRA
 * Kolla rötter
 * Den får i nuläget bara ut reella svar.
 */