using Microsoft.AspNetCore.Mvc;

namespace PracticeApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetStudentName()
        {
            return "Student name";
        }
    }
}
