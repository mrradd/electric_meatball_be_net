namespace models
{
    public class Chat
    {
        Guid Id {get; set;}
        Guid ThreadId {get; set;}
        string Message {get; set;}
        DateTime CreatedDate {get; set;}
        string Role {get; set;}
    }
}
