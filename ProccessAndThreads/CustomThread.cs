namespace ProccessAndThreads
{
    internal class CustomThread
    {
        public static void BackgroundAndCustomThread()
        {

        }

        public static async Task FetchGitUser()
        {
            string URL = "https://api.github.com/users/kellyncodes";
            using HttpClient httpClient = new();
            var Result = await httpClient.GetStringAsync(URL);
            Console.WriteLine(Result);
        }
    }
}
