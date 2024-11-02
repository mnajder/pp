using System;

class Program
{
    static void Main()
    {
        int licznik = 0; // Zmienna do zliczania liczb spełniających warunek

        Console.WriteLine("Liczby spełniające warunek:");
        
        for (int liczba = 1000; liczba <= 9999; liczba++)
        {
            // Dzielimy liczbę na dwie części
            int pierwszaCzesc = liczba / 100;  // Pierwsze dwie cyfry
            int drugaCzesc = liczba % 100;     // Ostatnie dwie cyfry

            // Obliczamy sumę kwadratów tych dwóch części
            int sumaKwadratow = (pierwszaCzesc * pierwszaCzesc) + (drugaCzesc * drugaCzesc);

            // Sprawdzamy, czy suma kwadratów jest równa oryginalnej liczbie
            if (sumaKwadratow == liczba)
            {
                Console.WriteLine(liczba);
                licznik++;
            }
        }

        Console.WriteLine($"Liczba liczb spełniających warunek: {licznik}");
    }
}