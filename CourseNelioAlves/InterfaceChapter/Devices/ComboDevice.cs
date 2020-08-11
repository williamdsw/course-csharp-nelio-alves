
namespace Devices
{
    // Cannot inherit multiple classes
    // public class ComboDevice : Scanner, Printer
    public class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDocument(string document)
        {
            System.Console.WriteLine($"ComboDevice processing: {document}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }

        public void Print(string document)
        {
            System.Console.WriteLine($"ComboDevice print: {document}");
        }
    }
}
