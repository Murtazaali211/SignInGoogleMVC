using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoogleAuthenticationMVC.Models;

namespace GoogleAuthenticationMVC.Controllers
{
    [Authorize]   
    public class EmployeesController : ApiController
    {        
        public EmployeesController()
        {

        }
        
        [HttpGet]
        [Route("api/Employees")]
        public IHttpActionResult Get()
        {
           // User.Identity.AuthenticationType;

            UsersDBEntities db = new UsersDBEntities();
            var employees = db.Employees;
            return Ok(employees);
        }
    }
}
