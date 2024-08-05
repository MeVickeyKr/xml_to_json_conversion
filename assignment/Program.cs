using System;
using System.IO;
using System.Xml.Serialization;
using Xml2CSharp;
using System.Text.Json;
using Newtonsoft.Json;

namespace assignment
{

    internal class Program
    {
        static void Main()
        {

            XmltoJsonConvertor <INFORMATION> xtj = new XmltoJsonConvertor <INFORMATION> ();
            XmltoJsonConvertor<INFORMATION>.ChangeTOObj(@"C:\assignmentfolder1\assignment.xml");
            XmltoJsonConvertor<INFORMATION>.ConvertTOJson(@"C:\assignmentfolder1\assignment.json");

            Console.ReadKey();
        }
    }
}
