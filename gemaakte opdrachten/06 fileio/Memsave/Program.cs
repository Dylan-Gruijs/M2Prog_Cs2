using Microsoft.VisualBasic;

namespace Memsave;

class Program
{
    string welkomstTekst = "hello world";
    string saveFile = "welkomState.txt";
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    private void Run()
    {
        bool bestaadDeFile = File.Exists(saveFile);
        if(bestaadDeFile -- )
        {
            welkomstTekst = File.ReadAllText(saveFile);
        }
        Console.WriteLine(welkomstTekst);
        while (true)
        {
            Console.WriteLine(welkomstTekst);
            Console.WriteLine("enter a text, then enter");
            welkomstTekst= Console.ReadLine();
        }
    }
}
