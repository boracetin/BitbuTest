using Business.Abstract;
using Domain.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<List<Student>> GetAll()
        {
            return await _studentService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Student> GetById(int id)
        {
            return await _studentService.GetElemanById(id);
        }

        [HttpDelete]
        public async Task Delete([FromBody] Student student)
        {
            await _studentService.Delete(student);
        }

        [HttpPost]
        public async Task<Student> Post([FromBody] Student student)
        {
            return await _studentService.Create(student);


        }
        [HttpPut]
        public async Task<Student> Put([FromBody] Student student)
        {
            return await _studentService.Update(student);
        }




    }
}
