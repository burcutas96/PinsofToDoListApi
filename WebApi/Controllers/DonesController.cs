using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DonesController : ControllerBase
    {
        IDoneService _doneService;

        public DonesController(IDoneService doneService)
        {
            _doneService = doneService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _doneService.GetAll();

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _doneService.Get(id);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Done done)
        {
            var result = _doneService.Add(done);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Done done)
        {
            var result = _doneService.Update(done);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Done done)
        {
            var result = _doneService.Delete(done);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
