using System;

namespace App36
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = true;
            bool check = false;
            int count = 0;
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            while (count != number)
            {
                if (Console.ReadLine() == input)
                {
                    Console.WriteLine(found);
                    check = true;
                    break;
                }
                count++;
            }
            if(check == false)
                Console.WriteLine(!found);
        }

    }
}
