
using System;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        string url = "https://www.rutgers.edu/"; // Replace with the actual URL

        // Measure baseline memory usage
        long baselineMemory = GC.GetTotalMemory(forceFullCollection: true);

        var totalStopwatch = new Stopwatch(); // Stopwatch for total time measurement
        totalStopwatch.Start();

        // DNS resolution
        var dnsStopwatch = new Stopwatch();
        dnsStopwatch.Start();
        var hostEntry = Dns.GetHostEntry(new Uri(url).Host);
        dnsStopwatch.Stop();

        // TCP handshake and request
        var requestStopwatch = new Stopwatch();
        requestStopwatch.Start();
        var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
        requestStopwatch.Stop();

        // Reading response content
        var readContentStopwatch = new Stopwatch();
        readContentStopwatch.Start();
        string pageContent = await response.Content.ReadAsStringAsync();
        readContentStopwatch.Stop();

        totalStopwatch.Stop();

        // Measure memory usage after loading the page
        long postLoadMemory = GC.GetTotalMemory(forceFullCollection: true);

        // Calculate the difference in memory usage
        double memoryDifference = (postLoadMemory - baselineMemory) / 1024.0 / 1024.0;
        Console.WriteLine($"Memory used to load the web page: {memoryDifference:N2} MiB");

        // Output the time taken
        Console.WriteLine($"Total time to load the web page: {totalStopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"DNS lookup time: {dnsStopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"TCP handshake and request time: {requestStopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Time taken to read response content: {readContentStopwatch.ElapsedMilliseconds} ms");
    }
}
