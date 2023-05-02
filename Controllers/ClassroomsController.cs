using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Classroom> Get()
        {
            return new List<Classroom>() {
                new Classroom(){
                    Code=1,
                    Name="1A",
                    SchoolCode=1
                },
                new Classroom(){
                    Code=2,
                    Name="1B",
                    SchoolCode=1
                },
                new Classroom(){
                    Code=3,
                    Name="2A",
                    SchoolCode=1
                },
                new Classroom(){
                    Code=4,
                    Name="2B",
                    SchoolCode=1
                },
                new Classroom(){
                    Code=5,
                    Name="9A",
                    SchoolCode=2
                },
                new Classroom(){
                    Code=6,
                    Name="9B",
                    SchoolCode=2
                },
                new Classroom(){
                    Code=7,
                    Name="9C",
                    SchoolCode=2
                },
                new Classroom(){
                    Code=8,
                    Name="10A",
                    SchoolCode=2
                },
                new Classroom(){
                    Code=9,
                    Name="10B",
                    SchoolCode=2
                },
                new Classroom(){
                    Code=10,
                    Name="11A",
                    SchoolCode=2
                }
            };
        }
    }
}
