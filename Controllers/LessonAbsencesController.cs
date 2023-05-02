using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonAbsencesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<LessonAbsence> Get()
        {
            return new List<LessonAbsence>() {
                new LessonAbsence(){
                    Code=1,
                    SchoolCode=1,
                    LessonCode=1,
                    StudentCode=1,
                    TeacherCode=1,
                    Status=1,
                    ClassroomCode=1,
                    StartDate=Convert.ToDateTime("2023-04-01 08:00"),
                    EndDate=Convert.ToDateTime("2023-04-01 08:45"),
                    CreationDate=Convert.ToDateTime("2023-04-01 08:05")
                },
                new LessonAbsence(){
                    Code=2,
                    SchoolCode=1,
                    LessonCode=2,
                    StudentCode=2,
                    TeacherCode=1,
                    Status=1,
                    ClassroomCode=1,
                    StartDate=Convert.ToDateTime("2023-04-03 09:00"),
                    EndDate=Convert.ToDateTime("2023-04-03 09:45"),
                    CreationDate=Convert.ToDateTime("2023-04-03 09:02")
                },
                new LessonAbsence(){
                    Code=3,
                    SchoolCode=1,
                    LessonCode=3,
                    StudentCode=3,
                    TeacherCode=3,
                    Status=1,
                    ClassroomCode=2,
                    StartDate=Convert.ToDateTime("2023-04-10 10:00"),
                    EndDate=Convert.ToDateTime("2023-04-03 10:45"),
                    CreationDate=Convert.ToDateTime("2023-04-10 10:08")
                },
                new LessonAbsence(){
                    Code=4,
                    SchoolCode=2,
                    LessonCode=2,
                    StudentCode=4,
                    TeacherCode=4,
                    Status=1,
                    ClassroomCode=2,
                    StartDate=Convert.ToDateTime("2023-04-17 09:00"),
                    EndDate=Convert.ToDateTime("2023-04-17 09:45"),
                    CreationDate=Convert.ToDateTime("2023-04-17 09:03")
                }
            };
        }
    }
}
