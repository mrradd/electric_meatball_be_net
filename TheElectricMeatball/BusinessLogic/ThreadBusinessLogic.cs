using Dtos;

namespace BusinessLogic
{
    public class ThreadBusinessLogic
    {
        private readonly IConfiguration _config;
        public ThreadBusinessLogic(IConfiguration config)
        {
            _config = config;
        }

        public CreateThreadResponseDto createNewThread(string name)
        {
            //TODO CH. ADD NEW THREAD TO DB
            CreateThreadResponseDto responseDto = new CreateThreadResponseDto()
            {
                
            };
            
            
            return responseDto;
        }
    }
}
