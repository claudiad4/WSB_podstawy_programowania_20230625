public enum DzienTygodnia
{
    Poniedziałek,
    Wtorek,
    Środa,
    Czwartek,
    Piątek,
    Sobota,
    Niedziela
}

public enum EtapPrania
{
    Płukanie,
    Pranie,
    Odwirowanie,
}

public enum Posilek
{
    Śniadanie,
    Lunch,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum BierkiSzachowe
{
    Król,
    Królowa,
    Wieża,
    Goniec,
    Koń,
    Pionek
}

class Program
{
    //Wypisz po jednym elemencie
    static void Main(string[] args)
    {
        DzienTygodnia dzien = DzienTygodnia.Poniedziałek;
        Console.WriteLine(dzien);

        EtapPrania etap = EtapPrania.Odwirowanie;
        Console.WriteLine(etap);

        Posilek posilek = Posilek.Lunch;
        Console.WriteLine(posilek);

        BierkiSzachowe bierka = BierkiSzachowe.Koń;
        Console.WriteLine(bierka);
    }
}
