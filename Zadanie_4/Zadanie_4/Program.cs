using System;
using System.Collections.Generic;

// Definicja typu wyliczeniowego do przechowywania płci
public enum Płeć { M, K }

// Definicja struktury Student
public struct Student
{
    public string nazwisko;
    public int nr_albumu;
    public double ocena;
    public Płeć plec;
}

public class Program
{
    // Funkcja wypełniająca instancję struktury Student
    public static void Wypelnij(ref Student s, string nazwisko, int nrAlbumu, double ocena, Płeć plec)
    {
        s.nazwisko = nazwisko;
        s.nr_albumu = nrAlbumu;

        // Sprawdzenie poprawności oceny
        if (ocena < 2.0)
        {
            s.ocena = 2.0;
        }
        else if (ocena > 5.0)
        {
            s.ocena = 5.0;
        }
        else
        {
            s.ocena = ocena;
        }

        s.plec = plec;
    }

    // Funkcja obliczająca średnią ocen w grupie
    public static double Srednia(List<Student> grupa)
    {
        double suma = 0.0;

        // Pętla sumująca oceny
        for (int i = 0; i < grupa.Count; i++)
        {
            suma += grupa[i].ocena;
        }

        // Obliczenie i zwrócenie średniej
        return suma / grupa.Count;
    }

    // Funkcja wyświetlająca informacje o studencie
    public static void Wyswietl(Student s)
    {
        Console.WriteLine("Nazwisko: " + s.nazwisko + ", Nr albumu: " + s.nr_albumu + ", Ocena: " + s.ocena + ", Płeć: " + s.plec);
    }

    public static void Main()
    {
        // Tworzenie listy studentów
        List<Student> grupa = new List<Student>();
        Student s1 = new Student();
        Student s2 = new Student();
        Student s3 = new Student();
        Student s4 = new Student();
        Student s5 = new Student();

        // Wypełnienie struktur danymi
        Wypelnij(ref s1, "Kowalski", 12345, 5.0, Płeć.M);
        Wypelnij(ref s2, "Nowak", 67890, 4.8, Płeć.K);
        Wypelnij(ref s3, "Malinowski", 10001, 3.7, Płeć.M);
        Wypelnij(ref s4, "Dąbrowska", 20002, 3.8, Płeć.K);
        Wypelnij(ref s5, "Wiśniewski", 30003, 4.9, Płeć.M);

        // Dodanie studentów do listy
        grupa.Add(s1);
        grupa.Add(s2);
        grupa.Add(s3);
        grupa.Add(s4);
        grupa.Add(s5);

        // Wyświetlenie
        for (int i = 0; i < grupa.Count; i++)
        {
            Wyswietl(grupa[i]);
        }

        Console.WriteLine("Średnia ocen w grupie: " + Srednia(grupa));
    }
}