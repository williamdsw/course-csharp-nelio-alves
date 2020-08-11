using System;

namespace Devices
{
    public class Scanner : Device, IScanner
    {
        public override void ProcessDocument(string document)
        {
            Console.WriteLine($"Scanner processing: {document}");
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
