namespace models
{
    public class ChatData
    {
        Guid Id {get; set;}
        string Model {get; set;}
        int TotalTokens {get; set;}
        DateTime CreatedDate {get; set;}
    }
}
