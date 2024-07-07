using System;
using Microsoft.Extensions.Configuration;
using Serilog;

// namespace bublesort{
//     class Program{
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//             Console.ReadLine();
//             //while (true) {
//             //    Console.WriteLine("");
//             //}
//         }
//     }
// }

try
{
    Log.Information("Start Console");

    var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true,true);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("======================================================================");
    Console.WriteLine("============== | ** Algorithm Console application ** | ===============");
    Console.WriteLine("======================================================================");
    Console.WriteLine("\n");

    Console.ForegroundColor = ConsoleColor.Green;
}catch(Exception ex){
    Console.WriteLine(ex.Message);
}