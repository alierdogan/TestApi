using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return new List<Lesson>() {
                new Lesson(){
                    Code=1,
                    Name="Matematik",
                    SchoolCode=1
                },
                new Lesson(){
                    Code=2,
                    Name="Tarih",
                    SchoolCode=1
                },
                new Lesson(){
                    Code=3,
                    Name="Türkçe",
                    SchoolCode=1
                },
                new Lesson(){
                    Code=4,
                    Name="Matematik",
                    SchoolCode=2
                },
                new Lesson(){
                    Code=5,
                    Name="Tarih",
                    SchoolCode=2
                },
                new Lesson(){
                    Code=6,
                    Name="Türkçe",
                    SchoolCode=2
                },
                new Lesson(){
                    Code=7,
                    Name="Kimya",
                    SchoolCode=2
                },
                new Lesson(){
                    Code=8,
                    Name="Biyoloji",
                    SchoolCode=2
                },
                new Lesson(){
                    Code=9,
                    Name="Fizik",
                    SchoolCode=2
                }
            };
        }
    }
}
