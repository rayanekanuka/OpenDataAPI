using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenDataLibrary
{
    // classe qui possède deux constructeurs, le premier vide qui appelle la MetroAPI, le deuxième avec l'interface en paramètre
    public class MetroAPI
    {
        // J'initialise mon paramètre _request
        private IRequest _request;
        private double _lat;
        private double _lon;
        private int _radius;

        public MetroAPI()
        {
            _request = new Request();
        }

        // Dans le cas où j'initialise une classe qui possède les méthodes de l'Interface (phase test)
        public MetroAPI(IRequest metroAPI)
        {
            _request = metroAPI;
        }

        //public MetroAPI(double lat, double lon, int radius)
        //{
        //    this.lat = lat;
        //    this.lon = lon;
        //    this.radius = radius;
        //}

        // Méthode qui appelle GetLines sur MetroAPI // 
        public List<TransportLine> GetLines(double lat, double lon, int radius)
        {
            string json = _request.DoRequest($"http://data.mobilites-m.fr/api/linesNear/json?x={lon.ToString(System.Globalization.CultureInfo.InvariantCulture)}&y={lat.ToString(System.Globalization.CultureInfo.InvariantCulture)}&dist={radius.ToString()}&details=true");
            //string json = _request.DoRequest("http://data.mobilites-m.fr/api/linesNear/json?x=5.731369390899194&y=45.18447955700181&dist=500&details=true");
            Console.WriteLine( json );

            // Déséralise le json en objet
            List<TransportLine> transport = JsonConvert.DeserializeObject<List<TransportLine>>(json);
            Console.WriteLine(transport);
            return transport;
        }
    }
}
