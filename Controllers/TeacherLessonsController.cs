using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherLessonsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TeacherLesson> Get()
        {
            return new List<TeacherLesson>() {
                new TeacherLesson(){
                    Code=1,
                    SchoolCode=1,
                    LessonCode=1,
                    TeacherCode=1,
                    Status=1
                },
                new TeacherLesson(){
                    Code=2,
                    SchoolCode=1,
                    LessonCode=2,
                    TeacherCode=1,
                    Status=1
                },
                new TeacherLesson(){
                    Code=3,
                    SchoolCode=1,
                    LessonCode=3,
                    TeacherCode=3,
                    Status=1
                },
                new TeacherLesson(){
                    Code=4,
                    SchoolCode=1,
                    LessonCode=2,
                    TeacherCode=4,
                    Status=1
                }
            };
        }
    }
}
