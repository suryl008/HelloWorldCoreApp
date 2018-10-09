using System;
using System.Net.Http;

namespace HelloWorldAPIConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {                
                string message = Display();
                Console.WriteLine(message);
                Console.ReadKey();
            }
        }

        public static string Display()
        {
            using (var httpClient = new HttpClient())
            {                
                var results = httpClient.GetStringAsync("http://localhost:16070/api/values").Result;
                return results;
            }
        }
    }
}
