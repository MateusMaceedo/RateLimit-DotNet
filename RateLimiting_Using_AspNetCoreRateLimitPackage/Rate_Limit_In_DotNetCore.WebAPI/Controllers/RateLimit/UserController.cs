using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Rate_Limit_In_DotNetCore.WebAPI.Controllers.RateLimit
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET api/user/get-all
        [Route("get-all")]
        [HttpGet]
        public GetAllUserOutput GetAll()
        {
            var output = new GetAllUserOutput();
            output.Data = new List<string>()
            {
                "Mateus",
                "Daiana"
            };
            return output;
        }

        // GET api/user/get-info
        [Route("get-info")]
        [HttpGet]
        public GeUserInfoOutput GetUserInfo()
        {
            var output = new GeUserInfoOutput();
            output.Name = "Mateus";
            return output;
        }
    }

    public class GetAllUserOutput
    {
        public List<string> Data { get; set; }

        public string Error { get; set; }
    }

    public class GeUserInfoOutput
    {
        public string Name { get; set; }

        public string Error { get; set; }
    }
}
