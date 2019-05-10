using System;

namespace Net.Core.Api.Boilerplate
{

	class Program {
        static void Main(string[] args) {
            Console.WriteLine("TCP - .Net Core API Boilerplate");
            System.Threading.Tasks.Task.Delay(3000).Wait();
            Console.WriteLine("Processing...");
            System.Threading.Tasks.Task.Delay(10000).Wait();
            Console.WriteLine("Done!");
        }
    }

}
