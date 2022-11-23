using Business.Abstract;
using Domain.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCenterController : ControllerBase
    {
        private ICourseCenterService _courseCenterService;
        public CourseCenterController(ICourseCenterService courseCenterService)
        {
            _courseCenterService = courseCenterService;
        }

        [HttpGet]
        public async Task<List<CourseCenter>> GetAll()
        {
            return await _courseCenterService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<CourseCenter> GetById(int id)
        {
            return await _courseCenterService.GetElemanById(id);
        }

        [HttpDelete]
        public async Task Delete([FromBody] CourseCenter courseCenter)
        {
            await _courseCenterService.Delete(courseCenter);
        }

        [HttpPost]
        public async Task<CourseCenter> Post([FromBody] CourseCenter courseCenter)
        {
            return await _courseCenterService.Create(courseCenter);


        }
        [HttpPut]
        public async Task<CourseCenter> Put([FromBody] CourseCenter courseCenter)
        {
            return await _courseCenterService.Update(courseCenter);
        }

    }
}
