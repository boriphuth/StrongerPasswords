using System;
using System.Diagnostics;

namespace StrongerPasswordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var hash = PasswordHash.CreateHash("password1234");
            PasswordHash.ValidatePassword("password1234", hash);

            stopWatch.Stop();

            Console.WriteLine("The hash was {0}", hash);
            Console.WriteLine("It took {0} ms to hash and validate a password.", stopWatch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}