using online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace online.Controllers.api
{
    public class MainController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        public IHttpActionResult GetItemsbySeX()
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            var accountdb = db.User;
            if (accountdb.Count() == 0)
            {
                return BadRequest("No Data Found");
            }
            //var accountdb2 = db.Items.Where(a => a.Type == SeX).GroupBy(nn => nn.Item_Name,
            //     (key, values) => new {  Img_Path= key,  Count = values.Count()});


            return Ok(accountdb.ToList());
        }
    }
}
