using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    public class StopWatch
    {
        public long startTimer = 0;
        public long stopTimer = 0;
        public long elapsed;


        public void start()
        {
            startTimer = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Start Time is: " + startTimer);
        }


        public void stop()
        {
            stopTimer = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Stop Time is: " + stopTimer);
        }

        public long getElapsedTime()
        {
            elapsed = stopTimer - startTimer;
            return elapsed;
        }

        public void stopWatch()
        {
            StopWatch sw = new StopWatch();

            Console.WriteLine("Press '1' to Start Time: ");
            int a = Convert.ToInt32(Console.ReadLine());
            sw.start();

            Console.WriteLine();
            Console.WriteLine("Press '2' to Stop Time: ");
            int b = Convert.ToInt32(Console.ReadLine());
            sw.stop();

            long l = sw.getElapsedTime();
            Console.WriteLine();
            Console.WriteLine("Total Time Elapsed(in millisec) is:" + l);
            Console.WriteLine();
            //double z = Convert. l / 1000;
            //Console.WriteLine(z);
            Console.WriteLine("Converting millisec to seconds: " + (double)l / 1000 + " sec");
            Console.ReadKey();


        }
    }
}
