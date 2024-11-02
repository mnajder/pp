// See https://aka.ms/new-console-template for more information

Console.WriteLine("podaj 1 liczbe przedziału!");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("podaj 2 liczbe przedziału!");
int y = Convert.ToInt32(Console.ReadLine());

int nieparzyst = x;
int suma = 0;
do
{
    if (nieparzyst % 2 != 0)
    {
        suma = suma + nieparzyst;
    }
    nieparzyst++;
}while(nieparzyst <= y);

Console.WriteLine(suma);