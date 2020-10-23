using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Russia;
using Ukrain;
using Belarus;

namespace L_2_population_task_11
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine();
            Moskov mos = new Moskov();
            mos.Moskow_showed();
            int Moskow_p = mos.inhabited_Moskov();
            Console.WriteLine("=======================================================");
            Kiev kij = new Kiev();
            kij.Kiev_showed();
            int Kiev_p = kij.inhabited_Kiev();
            Console.WriteLine("=======================================================");
            Minsk minsk = new Minsk();
            minsk.Minsk_showed();
            int Minsk_p = minsk.inhabited_Minsk();
            Console.WriteLine("=======================================================");
            if ((Moskow_p > Kiev_p) || (Moskow_p > Minsk_p))
            {
                Console.WriteLine("Populasion Moskow is high");
            }
            else
            {
                if ((Kiev_p > Moskow_p) || (Kiev_p > Minsk_p))
                {
                    Console.WriteLine("Populasion Kiev is high");
                }
                else
                {

                    if ((Minsk_p > Moskow_p) || (Minsk_p > Kiev_p))
                    {
                        Console.WriteLine("Populasion Kiev is high");
                    }
                }

            }
        }
    }
}
