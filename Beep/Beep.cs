using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beep
{
    class Beep
    {
        static public void Alarm(int hz, int time, int elapse, string exception)
        {
            if (hz >= 37)
            {
                try
                {
                    Console.Beep(hz, time * 1000);
                    if (elapse == 0)
                    {
                        return;
                    }
                    else
                    {
                        Thread.Sleep(elapse * 1000);
                    }
                }
                catch
                {

                }
            }
            else
            {
                Console.WriteLine(exception);
            }
        }

    }
}
