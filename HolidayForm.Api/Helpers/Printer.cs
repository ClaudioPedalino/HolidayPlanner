using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace HolidayPlanner.Api.Helpers
{
    public class Printer
    {
        public  static void PrintJsonInConsole<T>(T obj)
        {
            Console.WriteLine();
            foreach (var pair in JObject.Parse(JsonConvert.SerializeObject(obj, Formatting.Indented)))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"[{pair.Key}]: {pair.Value}");
                Console.ResetColor();
            }
        }
    }
}
