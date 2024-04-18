using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        DateTime startTime = DateTime.Now;

        await GetServerResponse("https://api.direct.yandex.ru/", "Server 1");
        await GetServerResponse("https://catfact.ninja/fact", "Server 2");
        await GetServerResponse("https://api.coindesk.com/v1/bpi/currentprice.json", "Server 3");

        TimeSpan totalTime = DateTime.Now - startTime;
        Console.WriteLine($"Total time: {totalTime.TotalMilliseconds} ms");
    }

    static async Task GetServerResponse(string url, string serverName)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); 

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response from {serverName}:");
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error from {serverName}: {ex.Message}");
            }
        }
    }
}