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
    class Room
    {
        internal int x, y;
        internal string[] level;
        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }

        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }
        Room start = new Room(0, 0, [
            "XXXXX",
            "X   X",
            "X   X",
            "X   X",
            "XXXXX",
            ]);
    }
    Dictionary<string, Room> rooms = new Dictionary<string, Room>();
    rooms.Add(start.GetRoomLocationKey(), start);

}


