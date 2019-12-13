using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SyncVersusAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            // runningAFiveSecondLastingTask(); //synchronous
            runningAFiveSecondLastingTaskAsync(); //asynchronous

            stopWatch.Stop();
            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds} ms");
        }

        private async static Task runningAFiveSecondLastingTaskAsync()
        {
            await Task.Run(()=> Thread.Sleep(5000));
        }

        private static void runningAFiveSecondLastingTask()
        {
            Thread.Sleep(5000);
        }
    }


}
