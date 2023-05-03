using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        readonly List<Teacher> Teachers;
        public TeachersController()
        {
            Teachers = new List<Teacher>() {
                new Teacher()
        {
            Code = 1,
                    Name = "Kenan",
                    Surname = "Doğan",
                    SchoolCode = 1
                },
                new Teacher()
        {
            Code = 2,
                    Name = "Durmuş",
                    Surname = "Kara",
                    SchoolCode = 1
                },
                new Teacher()
        {
            Code = 3,
                    Name = "Sevda",
                    Surname = "Ateş",
                    SchoolCode = 1
                },
                new Teacher()
        {
            Code = 4,
                    Name = "katip",
                    Surname = "Demir",
                    SchoolCode = 1
                },
                new Teacher()
        {
            Code = 5,
                    Name = "Engin",
                    Surname = "Denizer",
                    SchoolCode = 2
                },
                new Teacher()
        {
            Code = 6,
                    Name = "Cemal",
                    Surname = "Karaca",
                    SchoolCode = 2
                },
                new Teacher()
        {
            Code = 7,
                    Name = "Hacer",
                    Surname = "Sucu",
                    SchoolCode = 2
                },
                new Teacher()
        {
            Code = 8,
                    Name = "İpek",
                    Surname = "Demirel",
                    SchoolCode = 2
                },
                new Teacher()
        {
            Code = 9,
                    Name = "İnci",
                    Surname = "Yalın",
                    SchoolCode = 2
                }
    };
        }

        [HttpGet]
        public Result Get()
        {
            List< Teacher> teachers = Teachers.ToList();
            return new Result()
            {
                Data = (teachers != null) ? Teachers : null,
                Status = (teachers != null) ? "OK" : "",
                Error = (teachers != null) ? "" : "Kayıt bulunamadı"
            };
        }

        [HttpGet]
        [Route("[action]/{code:int}")]
        public Result GetByCode(int code)
        {
            Teacher teacher = Teachers.Where(f => f.Code == code).FirstOrDefault();
            return new Result()
            {
                Data = teacher ?? null,
                Status = (teacher != null) ? "OK" : "",
                Error = (teacher != null) ? "" : "Kayıt bulunamadı"
            };
        }
    }
}
