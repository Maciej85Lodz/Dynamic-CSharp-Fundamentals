using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace DynamicJSONWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        public void Post([FromBody]JObject value)
        {
            dynamic customer = value;

            string first = customer.firstName;
            string second = customer.secondName;
        }
    }
}
