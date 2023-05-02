using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<School> Get()
        {
            return new List<School>() {
                new School(){
                    Code=1,
                    Name="Mustafa Kemal İlköğretim Okulu"
                },
                new School(){
                    Code=2,
                    Name="Atatürk Lisesi"
                }
            };
        }
    }
}
