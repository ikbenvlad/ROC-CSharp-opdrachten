using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // vraag om kleur
                Console.WriteLine("hoi, welke kleur wil je dat de console wordt? (Engelse namen kunnen ook worden gebruikt)");

                // sla kleur op, maakt het continu gebruikbaar
                string input = Console.ReadLine()?.ToLower();

                // stopt het programma
                if (input == "stop")
                {
                    Console.WriteLine("het programma wordt nu gestopt");
                    break;
                }
                
                // alle kleuren die gebruikt worden.
                if (input == "rood" || input == "red")
                {
                    Console.WriteLine("Het wordt nu groen");
                    Console.ForegroundColor = ConsoleColor.Green;
                } else if (input == "groen" || input == "green")
                {
                    Console.WriteLine("Fuck jou het wordt rood");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }else if (input == "paars" || input == "purple" || input == "magenta")
                {
                    Console.WriteLine("De console wordt nu paars");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                } else if (input != "rood" || input != "red" || input != "groen" || input != "green")
                {
                    Console.WriteLine("Het wordt toch paars");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
            }
        }
    }
}
