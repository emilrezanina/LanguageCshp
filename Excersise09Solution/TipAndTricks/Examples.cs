using System;

namespace TipAndTricks
{
    public class Examples
    {
        //public const int ValueConstant;
        public const int ValueConstant = 3;
        public readonly object ReadonlyObject;
        public readonly int ReadonlyConstant /*= 2*/; // Ok, but using only on constructor

        public Examples()
        {
            //ValueConstant = 4; // Compiler error
            ReadonlyObject = new object();
            ReadonlyConstant = 3;
        }

        public bool Foo()
        {
            return true;
        }
    }
}
