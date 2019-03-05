using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise03.SamplesLibrary
{
    public static class OverFlowUnderFlow
    {
        public static void DoIt()
        {
            uint max = uint.MaxValue;
            uint min = uint.MinValue;

            Console.WriteLine($"max: {max}, min: {min}");
            checked
            {
                unchecked
                {
                    min--;
                    max++;
                }
            }
            Console.WriteLine($"max: {max}, min: {min}");
        }
    }
}
