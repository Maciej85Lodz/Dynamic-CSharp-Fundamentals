using System;
using System.IO;
using Newtonsoft.Json;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic jsonData = JsonConvert.DeserializeObject(File.ReadAllText("Customers.json"));

            dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application", throwOnError: true));
            excel.Visible = true;
            excel.Workbooks.Add();
            dynamic defaultWorksheet = excel.ActiveSheet;

            int currentRow = 1;
            foreach (dynamic Customer in jsonData.Customers)
            {
                defaultWorksheet.Cells[currentRow, "A"] = Customer.firstName;
                defaultWorksheet.Cells[currentRow, "B"] = Customer.secondName;
                currentRow++;
            }

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
}
