using Excersise03.SamplesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Excersise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Random number: {RandomNumberGenerator.Next()}");
            ConversionTest.DoIt();
            OverFlowUnderFlow.DoIt();
        }
    }
}
