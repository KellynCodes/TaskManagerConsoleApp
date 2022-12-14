using System.Text;
namespace ProccessAndThreads
{
public enum ChooseOption
{
    ListRunningTasks = 1,
    StartAProcess,
    KillAProcess,
    CreateCustomThread
}

    internal class Program
    {
      static async Task Main()
      {
            Console.Title = "KELLYNCODES TASK MANAGER";
            StringBuilder Options = new();
            Options.AppendLine("1. List Running Task\n2. Start New Task\n3. Kill already running process\n4. Create a custom Thread");
            Console.WriteLine(Options.ToString());
            if (int.TryParse(Console.ReadLine(), out int Result))
            {
                switch (Result)
                {
                    case (int)ChooseOption.ListRunningTasks:
                        ListRunnningTasks.RunningTasks();
                        break;
                    case (int)ChooseOption.StartAProcess:
            StartATask.StartAProccess();
                        break;
                        case (int)ChooseOption.KillAProcess:
                        KillProcess.KillProcessByInputingTheNameOfTheProcess();
                        break;
                    case (int)ChooseOption.CreateCustomThread:
                       await CustomThread.FetchGitUser();
                        break;
                    default:
                        Console.WriteLine("Entered value is not in list");
                        break;

                }

                Console.WriteLine("Do you want to quit this applicatoin");
                Console.WriteLine("Type [YES/NO]");
                string userAnswer = Console.ReadLine() ?? string.Empty;
                if(userAnswer.Trim().ToUpper() == "YES")
                {
                    Console.WriteLine("Your have closed this app\t Thanks for using KellynCodes TASK MANAGER");
                }else if(userAnswer.Trim().ToUpper() == "NO")
                {
                   await Main();
                }
            }
      }
    }
}

/*//App Domain
AppDomain defaultAD = AppDomain.CurrentDomain;
Console.WriteLine($"The id of this domain: {defaultAD.Id} Name of this domain: {defaultAD.FriendlyName}");*/