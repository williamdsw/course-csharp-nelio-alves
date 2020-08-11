
using CourseNelioAlves.InterfaceChapter.Devices;
using Devices;
using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Printer printer = new Printer() { SerialNumber = 1080 };
                printer.ProcessDocument("My letter");
                printer.Print("My letter");

                Scanner scanner = new Scanner() { SerialNumber = 2003 };
                scanner.ProcessDocument("My Email");
                Console.WriteLine(scanner.Scan());

                ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3921 };
                comboDevice.ProcessDocument("My dissertation");
                comboDevice.Print("My dissertation");
                Console.WriteLine(comboDevice.Scan());
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
