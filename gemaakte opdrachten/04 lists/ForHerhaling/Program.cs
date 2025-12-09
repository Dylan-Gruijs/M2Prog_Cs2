namespace ForHerhaling;
class Program
{
    static void Main(string[] args)
    {
        double[] prijzen = new double[] { 0.99, 5.60, 10.11, 67.69 };
        string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "Bloons" };
        Formulier[] formulieren = new Formulier[2];

        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "goedkoop en vies",
            Sterren = 2
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
        }
        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine();
        }
    }
    

}

internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }