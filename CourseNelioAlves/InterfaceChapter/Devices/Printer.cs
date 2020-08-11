using System;

namespace Devices
{
    public class Printer : Device, IPrinter
    {
        public override void ProcessDocument(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }

        public void Print(string document)
        {
            Console.WriteLine($"Printer print: {document}");
        }
    }
}
