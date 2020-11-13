using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTermer
{
    class Program
    {
        static void Main(string[] args)
        {
            Input termer = new Input();
            while (true)
            {
                termer.HandleInput();
                Console.ReadLine(); // La till den så att man kan läsa resultatet innan den frågar om man vill avsluta.
                Console.WriteLine("> Vill du fortsätta?");
                Console.WriteLine("> 1. Ja.");
                Console.WriteLine("> 2. Nej jag vill avsluta programmet.");
                string avsluta = Console.ReadLine();
                if (avsluta == "2")
                {
                    Environment.Exit(0);
                }
            }


            Console.ReadLine();
        }
    }
}
