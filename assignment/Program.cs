using System;
using System.IO;
using System.Xml.Serialization;
using Xml2Obj;
using System.Text.Json;
using Newtonsoft.Json;

namespace assignment
{

    internal class Program
    {
        static void Main()
        {

            ObjtoJsonConvertor <INFORMATION> xtj = new ObjtoJsonConvertor <INFORMATION> ();
            ObjtoJsonConvertor<INFORMATION>.ChangeTOObj(@"C:\assignmentfolder1\assignment.xml");
            ObjtoJsonConvertor<INFORMATION>.ConvertTOJson(@"C:\assignmentfolder1\assignment.json");

            Console.ReadKey();
        }
    }
}
