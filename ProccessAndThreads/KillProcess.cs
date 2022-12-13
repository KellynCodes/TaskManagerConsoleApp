using System;
using System.Diagnostics;

namespace ProccessAndThreads
{
    internal class KillProcess
    {
        public static void KillProccess(Process process)
        {
            try
            {
                foreach (var processes in Process.GetProcessesByName(process.ProcessName))
                {
                    processes.Kill(true);
                    Console.WriteLine($"The process with an ID: {processes.Id} Process name of {processes.ProcessName} has been Stoped");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public static void KillProcessByInputingTheNameOfTheProcess()
        {
            Console.WriteLine("These are the list are the list of process running\nWrite the name of any process you would like to stop");
            ListRunnningTasks.RunningTasks();
        EnterProcessName: Console.WriteLine("Enter name of the process you want to quit");
            string UserInput = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(UserInput))
            {
                Console.WriteLine("Please input the process name you would like to stop");
                goto EnterProcessName;
            }
         var ProcessName = UserInput;
            try
            {
                foreach (var processes in Process.GetProcessesByName(ProcessName))
                {
                    processes.Kill(true);
                    Console.WriteLine($"The process with an ID: {processes.Id} Process name of {processes.ProcessName} has been Stoped");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
