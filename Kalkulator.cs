using System;

class Program
{
    static void Main()
    {
        // Pobieranie pierwszej liczby
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1;

        while (!double.TryParse(Console.ReadLine(), out liczba1))
        {
            Console.Write("Błędna liczba! Podaj ponownie: ");
        }

        // Pobieranie drugiej liczby
        Console.Write("Podaj drugą liczbę: ");
        double liczba2;

        while (!double.TryParse(Console.ReadLine(), out liczba2))
        {
            Console.Write("Błędna liczba! Podaj ponownie: ");
        }

        // Pobranie operatora
        Console.Write("Podaj operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik = 0;

        // Wybór działania
        if (operacja == "+")
        {
            wynik = liczba1 + liczba2;
            Console.WriteLine("Wynik: " + wynik);
        }
        else if (operacja == "-")
        {
            wynik = liczba1 - liczba2;
            Console.WriteLine("Wynik: " + wynik);
        }
        else if (operacja == "*")
        {
            wynik = liczba1 * liczba2;
            Console.WriteLine("Wynik: " + wynik);
        }
        else if (operacja == "/")
        {
            if (liczba2 != 0)
            {
                wynik = liczba1 / liczba2;
                Console.WriteLine("Wynik: " + wynik);
            }
            else
            {
                Console.WriteLine("Nie można dzielić przez zero!");
            }
        }
        else
        {
            Console.WriteLine("Niepoprawna operacja!");
        }
    }
}