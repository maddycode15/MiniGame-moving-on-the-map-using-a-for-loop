using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("MiniGame");
            Console.WriteLine();

            // count 1 to 10;
            for (int i = 1; i <= 10; i = i + 1)  // i++ is an increment shortcut
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey(true);

        }
    }
}
