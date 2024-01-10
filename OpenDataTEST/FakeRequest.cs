using OpenDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataTEST
{
    public class FakeRequest : IRequest
    {
        public FakeRequest() { }

        public string DoRequest(string url)
        {
            // objet C# (deserealize) nécessaire en dur pour faire les tests
            string JsonObj = "[{\"id\":\"SEM:1696\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73233,\"lat\":45.18502,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:13\",\"SEM:C4\"]},{\"id\":\"SEM:1698\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73245,\"lat\":45.18482,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:13\",\"SEM:C4\"]},{\"id\":\"SEM:1765\",\"name\":\"Grenoble, Driant\",\"lon\":5.73409,\"lat\":45.18259,\"zone\":\"SEM_GENDRIANT\",\"lines\":[\"SEM:13\",\"SEM:C4\"]},{\"id\":\"SEM:1766\",\"name\":\"Grenoble, Driant\",\"lon\":5.7341,\"lat\":45.18229,\"zone\":\"SEM_GENDRIANT\",\"lines\":[\"SEM:13\",\"SEM:C4\"]},{\"id\":\"SEM:1990\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73117,\"lat\":45.18551,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:C1\"]},{\"id\":\"SEM:1991\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73149,\"lat\":45.18534,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:C1\"]},{\"id\":\"SEM:2254\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73174,\"lat\":45.18454,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:C\",\"SEM:E\",\"SEM:A\"]},{\"id\":\"SEM:2255\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73168,\"lat\":45.18454,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:C\",\"SEM:E\",\"SEM:A\"]},{\"id\":\"SEM:2272\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73178,\"lat\":45.18466,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:C\",\"SEM:A\"]},{\"id\":\"SEM:2273\",\"name\":\"Grenoble, Chavant\",\"lon\":5.7317,\"lat\":45.18466,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:C\",\"SEM:A\"]},{\"id\":\"SEM:4600\",\"name\":\"Grenoble, Chavant\",\"lon\":5.7318,\"lat\":45.18451,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:83\"]},{\"id\":\"SEM:4601\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73151,\"lat\":45.18455,\"zone\":\"SEM_GENCHAVANT\",\"lines\":[\"SEM:83\"]},{\"id\":\"C38:12812\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73117,\"lat\":45.18551,\"zone\":\"C38_ST05406\",\"lines\":[\"C38:T83\",\"C38:T84\",\"C38:T86\",\"C38:X01\",\"C38:X02\"]},{\"id\":\"C38:12813\",\"name\":\"Grenoble, Chavant\",\"lon\":5.73149,\"lat\":45.18534,\"zone\":\"C38_ST05406\",\"lines\":[\"C38:T83\",\"C38:T84\",\"C38:T86\",\"C38:X01\",\"C38:X02\"]}]";
            return JsonObj;

            //String text = "[{\"id\":\"test\",\"name\":\"test\",\"lon\":0.0,\"lat\":0.0,\"zone\":\"test\",\"lines\":[\"test\"]}]";
            //return text;
        }

    }
}
