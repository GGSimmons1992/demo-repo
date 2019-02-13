using System;

namespace ConsoleApp.SClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }

        static async void Display()
        {
            foreach (var mov in await MovieClient.GetAll())
            {
                Console.WriteLine($"{mov.Title}-{mov.Genre}");
            }
        }

    }
}
