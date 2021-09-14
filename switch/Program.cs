using System;

namespace Switch
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mis Hinde sa said");
        int UserGrade = Convert.ToInt32(Console.ReadLine());
        
        switch (UserGrade)
        {
            case 5:
                Console.WriteLine("Suurepärane");
                break;
            case 4:
                Console.WriteLine("Väga Hea");
                break;
            case 3:
                Console.WriteLine("Hea");
                break;
            case 2:
                Console.WriteLine("Rahuldav");
                break;
            case 1:
                Console.WriteLine("Puudulik");
                break;
        }
    }
}
}
