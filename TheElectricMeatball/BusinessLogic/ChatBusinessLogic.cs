using OpenAI.Chat;

public class ChatBusinessLogic
{
    private readonly IConfiguration _config;
    public ChatBusinessLogic(IConfiguration config)
    {
        _config = config;
    }

    public ChatResponseDto sendChatRequest(string message, string model, Guid threadId)
    {
        ChatClient client = new(model: model, apiKey: _config.GetValue<string>("OPENAI_API_KEY"));
        ChatCompletion completion = client.CompleteChat(message);
        Console.WriteLine($"[ASSISTANT]: {completion.Content[0].Text}");
        ChatResponseDto responseDto = new ChatResponseDto()
        {
            Response = completion.Content[0].Text,
        };
        //TODO CH Save new message to DB.
        //TODO CH Save response to DB.
        return responseDto;
    }
}