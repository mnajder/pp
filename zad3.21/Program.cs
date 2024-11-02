// See https://aka.ms/new-console-template for more information

Console.WriteLine("wpisz pierwszą podstawe: ");
int p1 =  Convert.ToInt32(Console.ReadLine());


Console.WriteLine("wpisz drugą podstawe: ");
int p2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wpisz drugą podstawe: ");
int p3 = Convert.ToInt32(Console.ReadLine());

if (p1 + p2 > p3)
{
    if (p1 + p3 > p2)
    {
        if (p2 + p3 > p1)
        {
            Console.WriteLine("trójkąt jest poprawny");
        }else
        {
            Console.WriteLine("nie można zrobić trójkąta");
        }
    }else
    {
        Console.WriteLine("nie można zrobić trójkąta");
    }
}else
{
    Console.WriteLine("nie można zrobić trójkąta");
}