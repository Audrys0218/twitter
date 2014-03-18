using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using DataContract;
using System.Runtime.Serialization;

namespace Business
{
    public class Search
    {
        public Response SearchRequest(string SearchStr, string BearerToken){

            var request = (HttpWebRequest)WebRequest.Create("https://api.twitter.com/1.1/search/tweets.json?q="+SearchStr);
            var authHeader = string.Format("Bearer {0}", BearerToken);
            request.Headers.Add("Authorization", authHeader);

            var response = (HttpWebResponse)request.GetResponse();
            DataContractSerializer jsonSerializer = new DataContractSerializer(typeof(Response));
            object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            Response jsonResponse = objResponse as Response;
            return jsonResponse;
        }
    }
}
