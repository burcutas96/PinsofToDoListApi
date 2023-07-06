using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _todoService.GetAll();

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _todoService.Get(id);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            var result = _todoService.Add(todo);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Todo todo)
        {
            var result = _todoService.Update(todo);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Todo todo)
        {
            var result = _todoService.Delete(todo);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
