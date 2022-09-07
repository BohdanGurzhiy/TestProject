using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Repo;

namespace TestProject.Controllers
{
    [Route("/")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestRepo _testRepo;
        public TestController(TestRepo testRepo)
        {
            _testRepo = testRepo;
        }

        [HttpGet ("reverse")]
        public IActionResult Reverse([FromQuery]string data)
        {
            if (data == null)
            {
                return Ok($"The parameter data is undefined!");
            }
            var response = new { result = _testRepo.ReverseOrSqrt(data) };
            return Ok(response);
        }
    }
}
