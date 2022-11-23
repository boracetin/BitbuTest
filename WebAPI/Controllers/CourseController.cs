using Business.Abstract;
using Domain.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<List<Course>> GetAll()
        {
            return await _courseService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Course> GetById(int id)
        {
            return await _courseService.GetElemanById(id);
        }

        [HttpDelete]
        public async Task Delete([FromBody] Course course)
        {
            await _courseService.Delete(course);
        }

        [HttpPost]
        public async Task<Course> Post([FromBody] Course course)
        {
            return await _courseService.Create(course);


        }
        [HttpPut]
        public async Task<Course> Put([FromBody] Course course)
        {
            return await _courseService.Update(course);
        }
    }
}
