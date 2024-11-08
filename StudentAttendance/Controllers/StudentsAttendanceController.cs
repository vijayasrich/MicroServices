using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendance.Models;

namespace StudentAttendance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsAttendanceController : ControllerBase
    {
        static List<StuAttendance> attendanceList;
        [HttpGet]
        public List<StuAttendance> Get()
        {
            attendanceList = new List<StuAttendance> {
               new StuAttendance() { StudentID=101,StudentName="Aara", AttendancePercentage=90},
                new StuAttendance() { StudentID=102,StudentName="luna", AttendancePercentage=91},
                new StuAttendance() { StudentID=103,StudentName="Sara", AttendancePercentage=92},
                new StuAttendance() { StudentID=104,StudentName="Tara", AttendancePercentage=93},

          };
            return attendanceList;
        }
    }
}
