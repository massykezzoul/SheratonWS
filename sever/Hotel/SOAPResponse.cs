using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel
{
    [Serializable]
    public class SOAPResponse
    {
        public bool success;
        public string message;
        public string agence;
        public List<Offre> result;
        
        public SOAPResponse()
        {
            this.success = false;
            this.message = "Construction par défault";
            this.agence = "Pas d'agence";
            this.result = null;
        }

        public SOAPResponse(bool success, string message, string agence, List<Offre> result)
        {
            this.success = success;
            this.message = message;
            this.agence = agence;
            this.result = result;
        }

        public static SOAPResponse errorResponse(string message, string agence)
        {
            return new SOAPResponse(false, "ERROR Message: "+ message, agence, null);
        }

        public static SOAPResponse successResponse(string agence, List<Offre> result)
        {
            return new SOAPResponse(true, "SUCCESS", agence, result);
        }

        public static SOAPResponse successResponse(string agence, string result)
        {
            return new SOAPResponse(true, result, agence, null);
        }
    }
}