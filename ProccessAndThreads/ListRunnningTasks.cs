using System.Diagnostics;

namespace ProccessAndThreads
{
    internal class ListRunnningTasks
    {
        public static void RunningTasks()
        {
            var runningProcessMethodSyntax = Process.GetProcesses().OrderBy(proc => proc.Id);
            foreach (var item in runningProcessMethodSyntax)
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"| Process ID: {item.Id} | Proccess name: {item.ProcessName} |");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();
            }
        }
    }

    internal class CheckIfaThreadIsBackgroundOrAlive
    {
         public static void IsAlive()
        {
           bool IsAlive = Thread.CurrentThread.IsAlive;
            var ThreadName = Thread.CurrentThread.Name = "KellynCodes Task Manger Console App";
            Console.WriteLine(IsAlive ? $"Yes {ThreadName} is alive" : $"No {Thread.CurrentThread.Name} is not alive");
        }  
        public static void IsBackground()
        {
            bool IsBackground = Thread.CurrentThread.IsBackground;
            var ThreadName = Thread.CurrentThread.Name = "KellynCodes Task Manger Console App";
            Console.WriteLine(IsBackground ? $"Yes {ThreadName} is Background" : $"No {Thread.CurrentThread.Name} is not Background");
        }
    }
}
