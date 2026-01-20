namespace _01_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run()
        {
            Console.WriteLine("Rahhhhh");

            Console.WriteLine("Do you like hamburgers?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);

            Console.WriteLine("Do you watch F1?");
            string antwoord2 = Console.ReadLine();
            Console.WriteLine(antwoord2);

            Console.WriteLine("what is your favorite food?");
            string antwoord3 = Console.ReadLine();
            Console.WriteLine(antwoord3);

            Console.WriteLine("What is your favorite game?");
            string antwoord4 = Console.ReadLine();
            Console.WriteLine(antwoord4);

            Console.WriteLine("What is your favorite show/movie?");
            string antwoord5 = Console.ReadLine();
            Console.WriteLine(antwoord5);
            
            string antwoord= Vraag7();
            Console.WriteLine(antwoord)
        }
        internal string Vraag7()
        {
            Console.WriteLine("Do you think you can survive a zombie apocalipse");
            string antwoord = Console.ReadLine();
            return antwoord;
        }

    }

}


