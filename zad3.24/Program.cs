// See https://aka.ms/new-console-template for more information

Console.WriteLine("podaj liczbe: ");
int liczba = Convert.ToInt32(Console.ReadLine());
int x = 1;
int suma = 1;

while (x <= liczba)
{
    suma = suma * x;
    x++;
}

Console.WriteLine(suma);