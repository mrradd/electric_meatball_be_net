public class ChatRequestDto
{
    string message;
    string model;
    Guid chatThreadId;
}

public class ChatResponseDto
{
    Guid id;
    Guid chatThreadId;
    DateTime createdDate;
    string message;
    string response;
    string model;
}