using System;

namespace TestApi
{
    public class LessonAbsence
    {
        public int Code { get; set; }
        public int SchoolCode { get; set; }
        public int ClassroomCode { get; set; }
        public int TeacherCode { get; set; }
        public int StudentCode { get; set; }
        public int LessonCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }
    }
}
