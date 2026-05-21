using System;

class Program
{
    static void Main()
    {
        // Pobranie liczby ocen
        Console.Write("Podaj liczbę ocen: ");

        int liczbaOcen;

        while (!int.TryParse(Console.ReadLine(), out liczbaOcen) || liczbaOcen <= 0)
        {
            Console.Write("Błędna wartość! Podaj dodatnią liczbę ocen: ");
        }

        double suma = 0;

        // Wprowadzanie ocen
        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write("Podaj ocenę nr " + i + " (1-6): ");

            double ocena;

            while (!double.TryParse(Console.ReadLine(), out ocena) || ocena < 1 || ocena > 6)
            {
                Console.Write("Błędna ocena! Podaj ocenę od 1 do 6: ");
            }

            suma += ocena;
        }

        // Obliczanie średniej
        double srednia = suma / liczbaOcen;

        // Wyświetlenie średniej
        Console.WriteLine("Średnia ocen wynosi: " + srednia);

        // Sprawdzenie zaliczenia
        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zaliczył przedmiot.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zaliczył przedmiotu.");
        }
    }
}