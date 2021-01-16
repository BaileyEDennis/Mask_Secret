using System;

namespace MaskInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Secret Prhase:");
            string line = Console.ReadLine();
            string hidden = "";

            for (int i = 0; i < line.Length - 4; i++)
            {
                hidden += "[]";
            }

            string reveal = line.Substring(line.Length - 4);
            Console.WriteLine($"Revealed: {hidden}{reveal}");

        }
    }
}
