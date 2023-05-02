using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLessonsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentLesson> Get()
        {
            return new List<StudentLesson>() {
                new StudentLesson(){
                    Code=1,
                    SchoolCode=1,
                    LessonCode=1,
                    StudentCode=1,
                    Status=1
                },
                new StudentLesson(){
                    Code=2,
                    SchoolCode=1,
                    LessonCode=2,
                    StudentCode=1,
                    Status=1
                },
                new StudentLesson(){
                    Code=3,
                    SchoolCode=1,
                    LessonCode=3,
                    StudentCode=3,
                    Status=1
                },
                new StudentLesson(){
                    Code=4,
                    SchoolCode=1,
                    LessonCode=2,
                    StudentCode=4,
                    Status=1
                }
            };
        }
    }
}
