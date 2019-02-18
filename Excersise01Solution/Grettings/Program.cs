using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grettings
{
    class Program
    {
        const uint DEFAULT_COUNT = 100;

        static uint GetCount(string[] args)
        {
            if (args.Length == 0) return DEFAULT_COUNT;
            if (uint.TryParse(args[0], out uint temp))
                return temp;
            return DEFAULT_COUNT;
        }

        static void Main(string[] args)
        {
            Console.Write("Hello world!");
            Console.WriteLine("Hello world again!");
            uint count = GetCount(args);
            //if (count != 0)
            //{
            //    string grettings = "Hello world ";
            //    grettings += "again";
            //    for (uint i = 1; i < count; i++)
            //    {
            //        grettings += " again";
            //    }
            //    grettings += "!";
            //    Console.WriteLine(grettings);
            //}

            if (count != 0)
            {
                StringBuilder grettingsBuilder = new StringBuilder();
                grettingsBuilder.Append("Hello world again");
                for (uint i = 1; i < count; i++)
                {
                    grettingsBuilder.Append(" again");
                }
                grettingsBuilder.Append("!");
                Console.WriteLine(grettingsBuilder.ToString());
            }

        }
    }
}
