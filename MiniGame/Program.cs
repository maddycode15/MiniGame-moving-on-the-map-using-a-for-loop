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

            // count 1 to 10 using a for loop
            for (int i = 1; i <= 10; i = i + 1)  // i++ is an increment shortcut
            {
                Console.WriteLine(i);
            }


            // a value declaired inside a for loop will only exist within the context
            // of that loop, you must declair and use it outside the loop in order for 
            // the loop to be referanced outside of the loop

            //for example (int i = 1; i <= 10; i = i + 1)

            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey(true);

        }
    }
}
