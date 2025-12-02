namespace _03_constructors;

class QuizVraag
{
    internal string vraag;
    internal string antwoord;

    internal QuizVraag(string vraag, string antwoord)
    {
        this vraag = vraag;
        this antwoord = antwoord;
    }

    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("hier komt vraag", "hier komt antwoord");
    }
}