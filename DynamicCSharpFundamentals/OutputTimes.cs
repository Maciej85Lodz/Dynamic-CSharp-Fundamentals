using System;
using static System.Console;

namespace DynamicCSharpFundamentals
{
    class OutputTimes
    {
        public static void OutputTimeStaticBinding()
        {
            DateTime dt = DateTime.Now;
            string time = dt.ToLongDateString();

            WriteLine(time);
        }

        public static void OutputTimeDynamicBinding()
        {
            dynamic dt = DateTime.Now;
            string time = dt.ToLongDateString();

            WriteLine(time);
        }

        public static void OutputTimeDynamicBindingRunTimeError()
        {
            dynamic dt = DateTime.Now;
            string time = dt.IsItCoffeeTime();

            WriteLine(time);
        }
    }
}
