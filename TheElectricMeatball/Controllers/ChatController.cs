using BusinessLogic;
using dtos;
using Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class ChatController : ControllerBase
    {
        private readonly ChatBusinessLogic _chatBusinessLogic;
        public ChatController(ChatBusinessLogic chatBusinessLogic)
        {
            _chatBusinessLogic = chatBusinessLogic;
        }

        [HttpPost]
        public ActionResult<ChatResponseDto> sendChat([FromBody] ChatRequestDto chatRequestDto)
        {
            try
            {
                ChatResponseDto responseDto = _chatBusinessLogic.sendChatRequest(chatRequestDto.Message, chatRequestDto.Model, chatRequestDto.ChatThreadId);
                return StatusCode(StatusCodes.Status201Created, responseDto);
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
