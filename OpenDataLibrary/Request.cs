using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataLibrary
{
    public class Request : IRequest
    {
        public Request()
        {
        }

        public string DoRequest(string url)
        {
            //Demande
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Crée une requête pour une URL. 		
            WebRequest request = WebRequest.Create(url);
            // Si requis par le serveur, initialise les informations d'identification.
            request.Credentials = CredentialCache.DefaultCredentials;


            // Obtenir une réponse.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Afficher le statut.
            Console.WriteLine(response.StatusDescription);

            // Récupère le flux contenant le contenu renvoyé par le serveur.
            Stream dataStream = response.GetResponseStream();
            // Ouvre le flux à l'aide du StreamReader pour un accès facile.
            StreamReader reader = new StreamReader(dataStream);


            // Lit le contenu 
            string responseFromServer = reader.ReadToEnd();
            // Console.WriteLine(responseFromServer); // pertmet de récupérer mon objet Json


            //Nettoie les flux et les réponses.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
