﻿using System;

namespace InstagramAgeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana
            //kui kasutaja on 13 aastat vana või vanem
            //siis ta võib Instagrami kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("Sisesta oma sünniaasta");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if(UserAge >= 13)
            {
                Console.WriteLine("Tere tulemast instagrami");
            }
            else
            {
                Console.WriteLine("Oled liiga noor");
            }
                       
             

        }

    }
}
