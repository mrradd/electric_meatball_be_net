using Microsoft.AspNetCore.Mvc;
using OpenAI.Chat;

[ApiController]
[Route("api/v1/[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
public class ChatController : ControllerBase
{
    private readonly IConfiguration _config;
    public ChatController(IConfiguration config)
    {
        _config = config;
    }

    [HttpPost]
    public IActionResult sendChat([FromBody] ChatRequestDto chatRequestDto)
    {
        try
        {
            ChatClient client = new(model: "gpt-4o", apiKey: _config.GetValue<string>("OPENAI_API_KEY"));

            ChatCompletion completion = client.CompleteChat("Say 'this is a test.'");

            Console.WriteLine($"[ASSISTANT]: {completion.Content[0].Text}");
            return Ok(completion.Content[0].Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR sendChat: {ex.Message}");
            object payload = new { error = "There was a problem sending the chat." };
            return StatusCode(StatusCodes.Status500InternalServerError, payload);
        }
    }
}