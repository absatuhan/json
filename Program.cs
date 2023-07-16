using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOkuma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string JsonOkunanData=File.ReadAllText("c://JsonIslemlerim//Personellerim.json");
            List<XObject> Data=Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(JsonOkunanData);
            for (int i = 0; i < Data.Count; i++)
            {
                Console.WriteLine(Data[i]);
            }

        }
    }
}
