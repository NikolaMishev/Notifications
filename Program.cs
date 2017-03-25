using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice101
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine(); 

                if (input == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();

                    ShowSuccess(operation, message);
                }

                if (input == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());

                    ShowError(operation, code);
                }

                if (input != "success" && input != "error")
                {
                    continue;
                }
            }
        }

        private static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        private static void ShowError(string operation, int code)
        {
            var reason = string.Empty;

            if (code > 0)
            {
                reason = "Invalid Client Data";
            }

            else if (code < 0)
            {
                reason = "Internal System Failure";
            }

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");        
        }
    }
}
