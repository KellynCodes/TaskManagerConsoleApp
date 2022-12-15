using System.Net;

namespace ProccessAndThreads
{
    internal class CustomThread
    {
        public static void BackgroundAndCustomThread()
        {
            ThreadStart threadStart = new(FetchDataFromApi);
            Thread thread = new(threadStart);
            thread.Name = "Fetching Data from JsonPlaceHolder";
            thread.Start();
        }

        public static async void FetchDataFromApi()
        {
            try
            {
                string URL = "https://jsonplaceholder.typicode.com/posts";
                string FormatedUrl = string.Format(URL);
                WebRequest RequestObject = WebRequest.Create(FormatedUrl);
                RequestObject.Method = "GET";
                HttpWebResponse Response;
                Response = (HttpWebResponse)RequestObject.GetResponse();
                string Result;
                using (Stream stream = Response.GetResponseStream())
                {
                    StreamReader streamReader = new(stream);
                    Result = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                var Users = Result;
                foreach (var user in Users)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(user.ToString());
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                ListRunnningTasks.RunningTasks();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               await Program.Main();
            }
        }

        public static async Task RunComputation()
        {
            Task<int> longRunningTask = HeavyComputationAsync();
            int result = await longRunningTask;
            Console.WriteLine(result);
        }

        public static async Task<int> HeavyComputationAsync()
        {
            await Task.Delay(10000);
            return 1;
        }
}

    }
