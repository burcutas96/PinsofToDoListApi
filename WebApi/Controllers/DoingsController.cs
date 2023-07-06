using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoingsController : ControllerBase
    {
        IDoingService _doingService;

        public DoingsController(IDoingService doingService)
        {
            _doingService = doingService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _doingService.GetAll();

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _doingService.Get(id);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Doing doing)
        {
            var result = _doingService.Add(doing);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Doing doing)
        {
            var result = _doingService.Update(doing);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Doing doing)
        {
            var result = _doingService.Delete(doing);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
