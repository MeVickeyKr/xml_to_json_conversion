using System;
using Xml2Obj;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;

namespace assignment
{
    public class ObjtoJsonConvertor <T>  where T : class
    {
         
       static T encode;
        public static void ChangeTOObj(string xmlpath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(INFORMATION));
            FileStream fileWriter = new FileStream(xmlpath, FileMode.Open);
            T encoding = (T)serializer.Deserialize(fileWriter);
            encode = (T)encoding;
            fileWriter.Close();
        }
        public static void ConvertTOJson(string Filepath2)
        {
            using (StreamWriter file1 = new StreamWriter(Filepath2))
            {
                string json = JsonConvert.SerializeObject(encode, Newtonsoft.Json.Formatting.Indented);
                file1.WriteLine(json);

            }
        }

    }
}
