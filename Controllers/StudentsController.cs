using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new List<Student>() {
                new Student(){
                    Code=1,
                    Name="Merve",
                    Surname="Doğan",
                    SchoolCode=1
                },
                new Student(){
                    Code=2,
                    Name="Kemal",
                    Surname="Tural",
                    SchoolCode=1
                },
                new Student(){
                    Code=3,
                    Name="Sevda",
                    Surname="Yılmaz",
                    SchoolCode=1
                },
                new Student(){
                    Code=4,
                    Name="Yılmaz",
                    Surname="Aslan",
                    SchoolCode=2
                },
                new Student(){
                    Code=5,
                    Name="Tahir",
                    Surname="Çetin",
                    SchoolCode=2
                },
                new Student(){
                    Code=6,
                    Name="Celil",
                    Surname="Gökçe",
                    SchoolCode=2
                },
                new Student(){
                    Code=7,
                    Name="Ezgi",
                    Surname="Yaman",
                    SchoolCode=2
                },
                new Student(){
                    Code=8,
                    Name="Yasemin",
                    Surname="Çiçek",
                    SchoolCode=2
                },
                new Student(){
                    Code=9,
                    Name="Kürşat",
                    Surname="Koç",
                    SchoolCode=2
                }
            };
        }
    }
}
