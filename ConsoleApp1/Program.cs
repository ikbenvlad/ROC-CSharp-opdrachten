namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vraag om kleur
            Console.WriteLine("hoi, welke kleur wil je dat de console wordt? (Engelse namen kunnen ook worden gebruikt)");

            // sla kleur op, dus zoiets: x = console.readline
            string input = Console.ReadLine();

            // als kleur is groen, maak console groen
            if (input == "groen" || input == "green")
            {
                Console.WriteLine("De console is nu groen.");
                Console.BackgroundColor = ConsoleColor.Green;
                return;
            }

            // als kleur is rood, maak console groen
            if (input == "rood" || input == "red")
            {
                Console.WriteLine("Het wordt toch groen");
                Console.BackgroundColor = ConsoleColor.Green;
                return;
            }

            // als kleur is paars, maak console paars
            if (input == "paars" || input == "purple" || input == "magenta")
            {
                Console.WriteLine("De console wordt nu paars");
                Console.BackgroundColor = ConsoleColor.Magenta;
                return;
            }

            // als het iets anders is, maak console paars
            if (input != "rood" || input != "red" || input != "groen" || input != "green")
            {
                Console.WriteLine("Het wordt toch paars");
                Console.BackgroundColor = ConsoleColor.Magenta;
                return;
            }
        }
    }
}
