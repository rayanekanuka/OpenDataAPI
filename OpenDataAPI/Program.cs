using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenDataLibrary;

namespace OpenDataAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            MetroAPI result = new MetroAPI();
            List<TransportLine> tag = result.GetLines();

            foreach (TransportLine transportLine in tag)
            {
                // affichage en chaîne interpolée grâce au $ du FrameWork
                Console.WriteLine($" Id :  {transportLine.Id}\t | Name : {transportLine.Name} | Latitude : {transportLine.Lat} | Longitude :  {transportLine.Lon}");
                //Console.WriteLine(" Id :  " + transportLine.id + "\t | Name : " + transportLine.name + " | Latitude : " + transportLine.lat + " | Longitude :  " + transportLine.lon + " | Lignes : " + line);
                foreach (string line in transportLine.Lines)
                {
                    Console.WriteLine($" Lignes : {line}");
                }
                Console.WriteLine();
            }
        }
    }
}
