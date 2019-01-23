using System;
using static System.Console;

namespace COMInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application", true);

            dynamic excel = Activator.CreateInstance(excelType);

            excel.Visible = true;
            excel.Workbooks.Add();

            dynamic defaultWorkSheet = excel.ActiveSheet;
            defaultWorkSheet.Cells[1, "A"] = "This is the Name Column";
            defaultWorkSheet.Columns[1].AutoFit();

            WriteLine("\n\nPress enter to exit...");
            ReadLine();

        }
    }
}
