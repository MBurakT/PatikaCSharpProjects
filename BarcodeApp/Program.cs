using System;
using Utilities;
using IronBarCode;
using System.IO;

namespace BarcodeApp;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (CustomFunctions.GetInputFromUser("to quit enter '0'").Equals("0"))
            {
                break;
            }

            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode("https://github.com/SecAccR", BarcodeEncoding.QRCode, 400, 180);
            barcode.AddAnnotationTextBelowBarcode("MBurakT");
            string path = Environment.CurrentDirectory + "\\BarcodeApp\\Images\\QrCode.png";
            if (File.Exists(path)) File.Delete(path);
            barcode.SaveAsPng(path);

            BarcodeResults barcd = BarcodeReader.Read(path);
            Console.WriteLine(barcd[0].Value);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Run(args);
            if (Console.ReadLine() == "clear") Console.Clear();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
        }
    }
}