using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro to Git");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hello there, this is my first Git Test");
            Console.Write("Do you like it so far? Y/N:");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.WriteLine("Great! There are so much more to come :)");
                Console.Write("Would you be interesing in learning more? Y/N:");
                if (Console.ReadLine().ToUpper() == "Y")
                    Console.WriteLine("Comming soon...");
                Console.WriteLine("Too bad, maybe you'll reconsider :)");
            }
            else
                Console.WriteLine("Too bad, maybe you'll reconsider :)");
            Console.ReadLine();
        }
    }
}
