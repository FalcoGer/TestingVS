using System;
using System.Runtime.CompilerServices;

# if DEBUG
// [assembly: InternalsVisibleTo()]
# endif
namespace TestingVS
{
    /// <summary>
    /// Entry point for the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountTo(5);
            Console.ReadKey();
        }

        /// <summary>
        /// Counts to countTo, then returns countTo
        /// </summary>
        /// <param name="countTo">Number to count up to</param>
        /// <returns>countTo</returns>
        static public int CountTo(int countTo = 10)
        {
            int i = 0;
            for (i = 0; i <= countTo; i++)
            {
                Console.WriteLine(i);
            }
            return i-1;
        }

        private static int Return4()
        {
            return 4;
        }

        private int Return8()
        {
            return 8;
        }

        private int Return8(int times)
        {
            return 8 * times;
        }

        private string Return8(string str)
        {
            return "Eight";
        }
    }
}
