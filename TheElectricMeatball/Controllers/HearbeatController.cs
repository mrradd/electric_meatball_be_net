using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class HeartbeatController : ControllerBase
{
    [HttpGet]
    public IActionResult getHeartbeat()
    {
        object payload = new
        {
            status = "ok",
            utc = DateTimeOffset.UtcNow,
            app = "The Electric Meatball",
            environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "unknown",
        };

        return Ok(payload);
    }
}