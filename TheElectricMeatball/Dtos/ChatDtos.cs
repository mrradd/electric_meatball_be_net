using OpenAI.FineTuning;

public class ChatRequestDto
{
    public string Message {get; set;}
    public string Model {get; set;}
    public Guid ChatThreadId {get; set;}
}

public class ChatResponseDto
{
    public Guid Id {get; set;}
    public Guid ChatThreadId {get; set;}
    public DateTime CreatedDate {get; set;}
    public string Response {get; set;}
    public string Role {get; set;}
}