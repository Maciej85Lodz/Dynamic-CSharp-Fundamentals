using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;


namespace DynamicCSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputTimeStaticBinding();
            OutputTimeDynamicBinding();
            OutputTimeDynamicBindingRunTimeError();

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }

        private static void OutputTimeStaticBinding()
        {
            DateTime dt = DateTime.Now;                       
            string time = dt.ToLongDateString();

            WriteLine(time);
        }

        private static void OutputTimeDynamicBinding()
        {
            dynamic dt = DateTime.Now;
            string time = dt.ToLongDateString();

            WriteLine(time);
        }

        private static void OutputTimeDynamicBindingRunTimeError()
        {
            dynamic dt = DateTime.Now;
            string time = dt.IsItCoffeeTime();

            WriteLine(time);
        }
    }
}
