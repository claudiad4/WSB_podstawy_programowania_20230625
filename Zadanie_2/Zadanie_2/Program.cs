public struct Student
{
    public string Imię;
    public string Nazwisko;
    public string Kierunek;
    public int Rok;
    public string Stopień;
}

public struct Przedmiot
{
    public string Nazwa;
    public string Prowadzący;
    public string Kierunek;
}

public struct NauczycielAkademicki
{
    public string TytułNaukowy;
    public string Imię;
    public string Nazwisko;
    public string Wydział;
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Imię = "Jan",
            Nazwisko = "Kowalski",
            Kierunek = "Informatyka",
            Rok = 2,
            Stopień = "Licencjat"
        };

        Przedmiot przedmiot = new Przedmiot
        {
            Nazwa = "Programowanie obiektowe",
            Prowadzący = "Dr Adam Nowak",
            Kierunek = "Informatyka"
        };

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki
        {
            TytułNaukowy = "Dr inż.",
            Imię = "Justyna",
            Nazwisko = "Kowalska",
            Wydział = "Wydział Informatyki"
        };

        Console.WriteLine("Student: " + student.Imię + " " + student.Nazwisko);
        Console.WriteLine("Przedmiot: " + przedmiot.Nazwa + ", Prowadzący: " + przedmiot.Prowadzący);
        Console.WriteLine("Nauczyciel: " + nauczyciel.TytułNaukowy + " " + nauczyciel.Imię + " " + nauczyciel.Nazwisko);
    }
}
