using LoginService.Bussiness;
using LoginService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LoginService.Controllers
{
    
    public class ValuesController : ApiController
    {
        // GET api/values
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<Productos> Get()
        {
            List<Productos> model =  Products.GetProducts();
            return model;
        }

        // GET api/values/jleon/jleon
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(string user, string password)
        {
            string result = "";
            if (LoginHelper.Autenticar(user, password))
                result = "success";
            else
                result = "fail";

            return result;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
