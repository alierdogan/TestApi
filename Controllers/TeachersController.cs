using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return new List<Teacher>() {
                new Teacher(){
                    Code=1,
                    Name="Kenan",
                    Surname="Doğan",
                    SchoolCode=1
                },
                new Teacher(){
                    Code=2,
                    Name="Durmuş",
                    Surname="Kara",
                    SchoolCode=1
                },
                new Teacher(){
                    Code=3,
                    Name="Sevda",
                    Surname="Ateş",
                    SchoolCode=1
                },
                new Teacher(){
                    Code=4,
                    Name="katip",
                    Surname="Demir",
                    SchoolCode=1
                },
                new Teacher(){
                    Code=5,
                    Name="Engin",
                    Surname="Denizer",
                    SchoolCode=2
                },
                new Teacher(){
                    Code=6,
                    Name="Cemal",
                    Surname="Karaca",
                    SchoolCode=2
                },
                new Teacher(){
                    Code=7,
                    Name="Hacer",
                    Surname="Sucu",
                    SchoolCode=2
                },
                new Teacher(){
                    Code=8,
                    Name="İpek",
                    Surname="Demirel",
                    SchoolCode=2
                },
                new Teacher(){
                    Code=9,
                    Name="İnci",
                    Surname="Yalın",
                    SchoolCode=2
                }
            };
        }
    }
}
