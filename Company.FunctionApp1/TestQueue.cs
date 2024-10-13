using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Company.FunctionApp1;

public static class TestQueue
{
    [FunctionName("TestQueue")]
    public static async Task RunAsync([QueueTrigger("myqueue", Connection = "AzureQueueConnectionTest")] string myQueueItem, ILogger log)
    {
        log.LogInformation("C# Queue trigger function processed: {MyQueueItem}", myQueueItem);
        await Task.Delay(5 * 1_000);
    }
}