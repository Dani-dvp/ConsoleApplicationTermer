    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTermer
{
    class Input
    {
        public void HandleInput()
        {
            Console.WriteLine("Du kommer att få skriva in två stycken operatorer följt av tre termer som du vill använda.");
            Console.WriteLine("Operatorer kan vara till exempel: x, +, - eller /.");
            Console.Write("Skriv in din första operator och tryck enter: ");
            string oper1 = Console.ReadLine();
            Console.Write("Skriv in din andra operator och tryck enter: ");
            string oper2 = Console.ReadLine();
            Console.Write("Skriv in din första term och tryck enter: ");
            int term1 = int.Parse(Console.ReadLine());
            Console.Write("Skriv in din andra term och tryck enter: ");
            int term2 = int.Parse(Console.ReadLine());
            Console.Write("Skriv in din tredje term och tryck enter: ");
            int term3 = int.Parse(Console.ReadLine());

            if (oper1 == "x" && oper2 == "x")
            {
                int sum = (term1 * term2 * term3);
                Console.WriteLine("\n> " + term1 + " x " + term2 + " x " + term3 + " = " + sum);
            }
            else if (oper1 == "x" && oper2 == "+")
            {
                int sum = (term1 * term2 + term3);
                Console.WriteLine("\n" + term1 + " x " + term2 + " + " + term3 + " = " + sum);
            }
            else if (oper1 == "x" && oper2 == "-")
            {
                int sum = (term1 * term2 - term3);
                Console.WriteLine("\n" + term1 + " x " + term2 + " - " + term3 + " = " + sum);
            }
            else if (oper1 == "x" && oper2 == "/")
            {
                int sum = (term1 * term2 / term3);
                Console.WriteLine("\n" + term1 + " x " + term2 + " / " + term3 + " = " + sum);
            }
            else if (oper1 == "/" && oper2 == "/")
            {
                int sum = (term1 / term2 / term3);
                Console.WriteLine("\n" + term1 + " / " + term2 + " / " + term3 + " = " + sum);
            }
            else if (oper1 == "/" && oper2 == "x")
            {
                int sum = (term1 / term2 * term3);
                Console.WriteLine("\n" + term1 + " / " + term2 + " x " + term3 + " = " + sum);
            }
            else if (oper1 == "/" && oper2 == "+")
            {
                int sum = term1 / (term2 + term3);
                Console.WriteLine("\n" + term1 + " / " + term2 + " + " + term3 + " = " + sum);
            }
            else if (oper1 == "/" && oper2 == "-")
            {
                int sum = (term1 / term2 - term3);
                Console.WriteLine("\n" + term1 + " / " + term2 + " - " + term3 + " = " + sum);
            }
            else if (oper1 == "+" && oper2 == "+")
            {
                int sum = (term1 + term2 + term3);
                Console.WriteLine("\n" + term1 + " + " + term2 + " + " + term3 + " = " + sum);
            }
            else if (oper1 == "+" && oper2 == "/")
            {
                int sum = term1 + (term2 / term3);
                Console.WriteLine("\n" + term1 + " + " + term2 + " / " + term3 + " = " + sum);
            }
            else if (oper1 == "+" && oper2 == "x")
            {
                int sum = term1 + (term2 * term3);
                Console.WriteLine("\n" + term1 + " + " + term2 + " x " + term3 + " = " + sum);
            }
            else if (oper1 == "+" && oper2 == "-")
            {
                int sum = (term1 + term2 - term3);
                Console.WriteLine("\n" + term1 + " + " + term2 + " - " + term3 + " = " + sum);
            }
            else if (oper1 == "-" && oper2 == "-")
            {
                int sum = (term1 - term2 - term3);
                Console.WriteLine("\n" + term1 + " - " + term2 + " - " + term3 + " = " + sum);
            }
            else if (oper1 == "-" && oper2 == "+")
            {
                int sum = (term1 - term2 + term3);
                Console.WriteLine("\n" + term1 + " - " + term2 + " + " + term3 + " = " + sum);
            }
            else if (oper1 == "-" && oper2 == "/")
            {
                int sum = term1 - (term2 / term3);
                Console.WriteLine("\n" + term1 + " - " + term2 + " / " + term3 + " = " + sum);
            }
            else if (oper1 == "-" && oper2 == "x")
            {
                int sum = (term1 - (term2 * term3));
                Console.WriteLine("\n" + term1 + " - " + term2 + " x " + term3 + " = " + sum);
            }
        }
    }
}
