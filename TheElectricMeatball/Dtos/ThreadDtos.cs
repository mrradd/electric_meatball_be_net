using OpenAI.FineTuning;

namespace Dtos
{
    public class CreateThreadRequestDto
    {
        public string name {get; set;}
    }

    public class CreateThreadResponseDto
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public DateTime CreatedDate {get; set;}
    }
}
