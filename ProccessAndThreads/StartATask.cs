using System.Diagnostics;
using System.Text;

namespace ProccessAndThreads
{
    internal class StartATask
    {
        public static int _verbId;
        public static Process? _Process = null;

        /// <summary>
        /// Starting a new process that the system will run
        /// </summary>
        public static void StartAProccess()
        {
            try
            {
                /*valid file name: C:/Users/KELLYNCODES/Downloads/OIP.jpg*/
                Console.Title = "Start a Task";
                Console.WriteLine("Enter file name to open");
                string fileInput = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter text to serach");
                string BrowserTab = Console.ReadLine() ?? string.Empty;
                ProcessStartInfo processStart = new($@"{fileInput.Trim()}", $"{BrowserTab}");
                _verbId = 0;
                foreach (var verb in processStart.Verb)
                {
                    Console.WriteLine($"{_verbId++} {verb}");
                }

                processStart.WindowStyle = ProcessWindowStyle.Normal;
                processStart.Verb = "Open";
                processStart.UseShellExecute = true;
                _Process = Process.Start(processStart);

            }
            catch (Exception exceptonMessage)
            {
                Console.WriteLine(exceptonMessage.Message);
                StartAProccess();
            }

            Console.WriteLine($"Do you want to kill this process: {_Process?.ProcessName}");
             StringBuilder Options = new();
            Options.AppendLine("1. Yes\n2. No");
            Console.WriteLine(Options);
            if (int.TryParse(Console.ReadLine(), out int Output))
            {
                const int YES = 1;
                const int NO = 2;
                switch (Output)
                {
                    case YES:
                        KillProcess.KillProccess(_Process);
                        break;
                    case NO:
                        Console.WriteLine($"{_Process?.ProcessName} is still running");
                        break;
                }
            }
        }
       
    }
}
