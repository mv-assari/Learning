namespace InitWebApi.Models.Entities.Dtos
{
    public class LoginResultDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public LoginDataDto Data { get; set; }

    }
}
