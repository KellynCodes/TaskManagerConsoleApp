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
}
