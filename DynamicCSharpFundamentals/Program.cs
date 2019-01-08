using System;
using static System.Console;


namespace DynamicCSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutputTimes.OutputTimeStaticBinding();
            //OutputTimes.OutputTimeDynamicBinding();
            //OutputTimes.OutputTimeDynamicBindingRunTimeError();

            int i = 42;
            dynamic di = i;
            int i2 = di;
            WriteLine($"i = {i} di = {di} i2 = {i2}");


            //string s = "hello";
            //dynamic ds = s;
            //int x = ds;
            long l = 99;
            dynamic dl = l;
            int y = (int)dl;


            WriteLine($"l = {l} dl = {dl} y = {y}");

            dynamic z = "Hi Maciej";

            WriteLine($"z is a {z.GetType()} = {z}");

            z = 42;
            WriteLine($"z is a {z.GetType()} = {z}");


            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }

        
    }
}
