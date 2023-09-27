using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Resources;
using System.Runtime.InteropServices;

namespace Nice_Argument2
{
    internal class Program
    {
        static string[] quotes = { "L", "ratio", "FRIENDLY FIRE", "ULTRACOUNTERRICOSHOT",
        "GROUND SLAM", "HEADSHOT", "u fell off", "LIMB HIT", "NAILBOMBED", "cringe",
        "FINISHED OFF", "PARRY", "FRIED", "CRITICAL PUNCH", "FIREWORKS", "OUT OF BOUNDS",
        "DISRESPECT", "ENRAGED", "SHREDDED", "MINCED", "CRUSHED", "skill issue",
        "INTERRUPTION", "SPLATTERED", "FISTFUL OF DOLLER", "HOMERUN", "DOWN TO SIZE",
        "ZAPPED", "CATAPULTED", "CANNONBALLED", "MAURICED", "HALF OFF", "CONDUCTOR",
        "EXPLODED", "CHARGEBACK", "BIG KILL" };
        static int[] blue = {10,14,24,26};
        static int[] green = {11,22};

       

        static void Main(string[] args)
        {
           Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(33, 15);
            Console.Title = "Unfortunately...";
            
            Thread.Sleep(3000);
            Console.WriteLine("CALIBRATION...\n");
            
            Thread.Sleep(500);
            Console.Write("VIDEO\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK\n");
            Console.ForegroundColor = ConsoleColor.White;
           
            Thread.Sleep(500);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {

                Console.Write("AUDIO\t");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK\n\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                SoundPlayer music = new SoundPlayer(Nice_Argument2.Properties.Resources.Music);
               music.PlayLooping();
            }
            else
            {
                Console.Write("AUDIO\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR\n\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Thread.Sleep(5000);
            Console.WriteLine("nice argument... \n\nunfortunately:\n");
            Thread.Sleep(1000);

            for (int i = 0; i < quotes.Length; i++)
            {
                if (blue.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }else if(green.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(i == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }else if (i == 3)
                {
                    Thread.Sleep(1200);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("+ ULTRA");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("COUNTER");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("RICOSHOT\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Thread.Sleep(1200);
                if (i != 3) { 
                Console.WriteLine("+ " + quotes[i]);
                }

            }
            
            for(int i = 0; i <4; i++)
            {
               Thread.Sleep(2000);
                Console.WriteLine("\n");
            }
            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
