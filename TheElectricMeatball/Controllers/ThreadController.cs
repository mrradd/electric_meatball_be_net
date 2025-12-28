using BusinessLogic;
using Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class ThreadController : ControllerBase
    {
        private readonly ThreadBusinessLogic _threadBusinessLogic;
        public ThreadController(ThreadBusinessLogic threadBusinessLogic)
        {
            _threadBusinessLogic = threadBusinessLogic;
        }

        [HttpPost]
        public ActionResult<CreateThreadResponseDto> saveThread([FromBody] CreateThreadRequestDto threadRequestDto)
        {
            try
            {
                CreateThreadResponseDto responseDto = _threadBusinessLogic.createNewThread(threadRequestDto.name);
                return StatusCode(StatusCodes.Status201Created, "yay");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR sendChat: {ex.Message}");
                object payload = new { error = "There was a problem sending the chat." };
                return StatusCode(StatusCodes.Status500InternalServerError, payload);
            }
        }
    }
}