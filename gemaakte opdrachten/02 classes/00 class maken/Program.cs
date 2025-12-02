namespace _00_class_maken;

class Program
{
    static void Main(string[] args)
    {
        Program program = new  Program();
        program.Run();
    }
    internal void Run()
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AA824H",
            kilometerStand = 20567,
            merk = "volkswagen"
        };
        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometerStand = 65739,
            merk = "volvo"
        };
        RijLeeraar rijLeeraar = new RijLeeraar()
        {
            leeftijd = 30,
            naam = "John",
            zzp = false
        };
        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijLeraar = rijLeeraar,
            tijd = 1130
        };
        LesPakket lesPakket1 = new LesPakket()
        {
            urenGekocht = 30,
            urenVerbruikt = 28,
            examenPogingen = 2,
            automaat = false,
        };
        TheorieTest theorieTest1 = new TheorieTest()
        {
            aantalFouten = 4,
            gehaald = true,
            afnameDatum = new DateTime(1300)
        };
        Student student = new Student()
        {
            naam = "Burger",
            leeftijd = 22,
            lesPakket = lesPakket1,
        };
    }
}
