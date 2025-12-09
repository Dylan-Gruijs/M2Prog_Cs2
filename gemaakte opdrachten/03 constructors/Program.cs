namespace _03_constructors;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Quiz quiz = new Quiz(10);
        quiz.VoegVraagToeOpIndex(0, quizVraag);
        QuizVraag quizVraag = new QuizVraag("hier komt vraag", "hier komt antwoord");
    }
    
}
