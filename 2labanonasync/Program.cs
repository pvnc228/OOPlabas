using System;
using System.Net;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        DateTime startTime = DateTime.Now;

        using (WebClient client = new WebClient())
        {
            try
            {
                string response = client.DownloadString("https://api.direct.yandex.ru/");
                Console.WriteLine("Response from Server 1:");
                Console.WriteLine(JsonConvert.SerializeObject(response, Formatting.Indented));
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error from Server 1: {ex.Message}");
            }
        }

        using (WebClient client = new WebClient())
        {
            try
            {
                string response = client.DownloadString("https://catfact.ninja/fact");
                Console.WriteLine("Response from Server 2:");
                Console.WriteLine(JsonConvert.SerializeObject(response, Formatting.Indented));
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error from Server 2: {ex.Message}");
            }
        }

        using (WebClient client = new WebClient())
        {
            try
            {
                string response = client.DownloadString("https://api.coindesk.com/v1/bpi/currentprice.json");
                Console.WriteLine("Response from Server 3:");
                Console.WriteLine(JsonConvert.SerializeObject(response, Formatting.Indented));
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error from Server 3: {ex.Message}");
            }
        }

        TimeSpan totalTime = DateTime.Now - startTime;
        Console.WriteLine($"Total time: {totalTime.TotalMilliseconds} ms");
    }
}