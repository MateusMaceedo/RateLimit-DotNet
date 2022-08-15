using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RateLimiting_Using_AspNetCoreRateLimitPackage.Controllers
{
    [Route("employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("getAllEmployees")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return GetEmployeesDeatils();
        }
    }
}