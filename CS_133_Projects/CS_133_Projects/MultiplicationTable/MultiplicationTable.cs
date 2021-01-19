using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CS_133_Projects.GenericClasses;

namespace CS_133_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myTimesTable = new int[10, 10];

            for (int y=0;y<10;y++)
            {
                for (int x=0;x<10;x++)
                {
                    myTimesTable[x, y] = (x+1) * (y+1); 
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(myTimesTable[x, y] + " ");
                }

                Console.WriteLine("");
            }
        }
    }
}

