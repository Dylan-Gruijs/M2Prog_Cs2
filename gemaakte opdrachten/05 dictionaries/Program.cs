namespace _05_dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
        personeelOpNummer.Add(1000, "rahh");
        personeelOpNummer.Add(2000, "Dihh");
        
        string Dihh = personeelOpNummer[2000];
        string rahh = personeelOpNummer[1000];
        
        Console.WriteLine(Dihh);
        Console.WriteLine(rahh);

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            Console.WriteLine();
        }
         foreach (int key in personeelOpNummer.Keys)
        {
            Console.WriteLine();
        }
         foreach (string value in personeelOpNummer.Values)
        {
            Console.WriteLine();
        }
    }


    internal void Run()
    {

    }

}

