using System.Net;

namespace ProccessAndThreads
{
    internal class CustomThread
    {
        public static void BackgroundAndCustomThread()
        {

        }

        public static void FetchGitUser()
        {
            string URL = "https://jsonplaceholder.typicode.com/posts";
            string FormatedUrl = string.Format(URL);
            WebRequest RequestObject =  WebRequest.Create(FormatedUrl);
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
            foreach(var user in Users)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(user.ToString());
            }
        }
    }
}
