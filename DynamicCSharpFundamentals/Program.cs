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

            //int i = 42;
            //dynamic di = i;
            //int i2 = di;
            //WriteLine($"i = {i} di = {di} i2 = {i2}");


            ////string s = "hello";
            ////dynamic ds = s;
            ////int x = ds;
            //long l = 99;
            //dynamic dl = l;
            //int y = (int)dl;


            //WriteLine($"l = {l} dl = {dl} y = {y}");

            //dynamic z = "Hi Maciej";

            //WriteLine($"z is a {z.GetType()} = {z}");

            //z = 42;
            //WriteLine($"z is a {z.GetType()} = {z}");


            int i = 42;
            PrintMe(i);  // --> PrintMe(int value) static binding

            dynamic d;
            //WriteLine("Create [i]nt or [d]ouble");
            //ConsoleKeyInfo choice = ReadKey(intercept: true);
            //if (choice.Key == ConsoleKey.I)
            //{
            //    d = 99;
            //}
            //else
            //{
            //    d = 55.5;
            //}
            //PrintMe(d);

            d = long.MaxValue;
            PrintMe(d);

            d = "Hi Maciej";
            PrintMe(d);

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }

        static void PrintMe(int value)
        {
            WriteLine($"PrintMe(int) called value: {value}");
        }

        static void PrintMe(long value)
        {
            WriteLine($"PrintMe(long) called value: {value}");
        }

        static void PrintMe(dynamic value)
        {
            WriteLine($"PrintMe(dynamic) called with a {value.GetType()} value: {value}");
        }

        //static void PrintMe(object value)
        //{
        //    WriteLine($"PrintMe(object value) = value: {value}");
        //}


    }
}
