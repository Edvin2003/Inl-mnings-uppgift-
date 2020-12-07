using System;

namespace Inlämningsuppgift1
{
	class Program
	{
		static void Main(string[] args)
		{
        Restart:
            Random slump = new Random();
            int gissatTal = 0;
            int försök = 0;
            int slumpTal = slump.Next(1, 101);
            while (gissatTal != slumpTal)
            {
                Console.WriteLine("Gissa på ett tal mellan 1 och 100");
                gissatTal = int.Parse(Console.ReadLine());
                försök++;

                if (gissatTal < 1 || gissatTal > 100)
                {
                    Console.WriteLine("Du måste gissa på ett tal som är mellan 1 och 100.");
                }

                if (gissatTal > slumpTal && !(gissatTal > 100))
                {
                    Console.WriteLine("Fel gissat!");
                    Console.WriteLine("Slumptalet är lägre än vad du har gissat.");
                }

                if (gissatTal < slumpTal && !(gissatTal < 1))
                {
                    Console.WriteLine("Fel gissat!");
                    Console.WriteLine("Slumptalet är högre än vad du har gissat.");
                }

                if (gissatTal == slumpTal)
                {
                    Console.WriteLine("Rätt gissat!");
                    Console.WriteLine("Det tog dig " + försök + " gånger att gissa!");
                    goto Restart;
                }
            }
        }
    }
	
}
