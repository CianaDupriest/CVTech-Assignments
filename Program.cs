using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(new String('*', i));
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(new String('*', i));
            }
        }
    }
}
