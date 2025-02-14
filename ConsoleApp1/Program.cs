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
                switch (input)
                {
                    case "rood":
                    case "red":
                        Console.WriteLine("De console wordt nu rood");
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "groen":
                    case "green":
                        Console.WriteLine("De console wordt nu groen");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "paars":
                    case "purple":
                    case "magenta":
                        Console.WriteLine("De console wordt nu paars");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.WriteLine("Het wordt toch paars");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                }
            }
        }
    }
}
