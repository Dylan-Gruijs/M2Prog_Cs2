namespace _06_fileio;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Run();
    }
    private void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
        for(int i =0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
        string[] artikellines = File.ReadAllLines("nos.nl");
        for(int i =0; i < artikellines.Length; i++)
        {
            Console.WriteLine(artikellines[i]);
        }
    }   
}
