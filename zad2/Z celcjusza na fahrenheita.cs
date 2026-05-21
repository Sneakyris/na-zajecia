using System;

class Program
{
    static void Main()
    {
        // Wybór kierunku konwersji
        Console.Write("Wybierz konwersję (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ");
        string wybor = Console.ReadLine() ?? "";

        // Zamiana na wielką literę
        wybor = wybor.ToUpper();

        // Konwersja C -> F
        if (wybor == "C")
        {
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");

            double celsjusz;

            while (!double.TryParse(Console.ReadLine(), out celsjusz))
            {
                Console.Write("Błędna wartość! Podaj ponownie: ");
            }

            double fahrenheit = celsjusz * 1.8 + 32;

            Console.WriteLine("Temperatura w Fahrenheitach: " + fahrenheit);
        }

        // Konwersja F -> C
        else if (wybor == "F")
        {
            Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");

            double fahrenheit;

            while (!double.TryParse(Console.ReadLine(), out fahrenheit))
            {
                Console.Write("Błędna wartość! Podaj ponownie: ");
            }

            double celsjusz = (fahrenheit - 32) / 1.8;

            Console.WriteLine("Temperatura w Celsjuszach: " + celsjusz);
        }

        // Niepoprawny wybór
        else
        {
            Console.WriteLine("Niepoprawny wybór!");
        }
    }
}