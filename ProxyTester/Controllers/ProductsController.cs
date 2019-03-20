using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProxyTester.Controllers
{
    public class ProductsController : ApiController
    {
        public IHttpActionResult GetProduct(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync("http://dummy.restapiexample.com/api/v1/employees");
            
            return Ok(response.Result);
        }
    }
}
