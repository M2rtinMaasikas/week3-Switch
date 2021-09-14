using System;

namespace ControlFlowPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada pin koodi
            //programm võrdleb sisustatud pin koodiga arvuga 1234
            //kui sesestatud pin kood on 1234
            //kui  sisestatud pin vale, programm kuvab konsoolis "Vale pin, proovi uuesti."

            Console.WriteLine("vaja sisestada pin koodi");
            int UserPin = Convert.ToInt32(Console.ReadLine());

           /* if (UserPin == 1234)
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale pin, proovi uuesti");
            }   */
        }



    }
}
