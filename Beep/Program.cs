using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            bool secok = false;
            bool hzok = false;
            int hz = 0;
            int time = 0;
            do
            {
                try
                {
                    Console.Write("Entrer une fréquence en Hertz (entier) : "); 
                    hz = Convert.ToInt32(Console.ReadLine());
                    hzok = true;
                }
                catch
                {
                    hzok = false;
                }
            } while (!hzok);
            
            do
            {
                try
                {
                    Console.Write("Pendant combien de temps en seconde (entier) : ");
                    time = Convert.ToInt32(Console.ReadLine());
                    secok = true;
                }
                catch
                {
                    secok = false;
                }
            } while (!secok);
            try
            {
                Beep.Alarm(hz, time, 5, "Can't work under 36 Hz. Please reload !");
            }
            catch
            {
                Console.WriteLine("Doesn't Work !");
            }
            Console.ReadKey();
        }
    }
}
