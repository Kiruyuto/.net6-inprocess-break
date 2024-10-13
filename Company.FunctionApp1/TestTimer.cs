using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Company.FunctionApp1;

public class TestTimer
{
    [FunctionName("TestTimer")]
    public async Task RunAsync([TimerTrigger("0 */5 * * * *", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation("C# Timer trigger function executed at: {UtcNow}", DateTime.UtcNow);
        await Task.Delay(5 * 1_000);
    }
}