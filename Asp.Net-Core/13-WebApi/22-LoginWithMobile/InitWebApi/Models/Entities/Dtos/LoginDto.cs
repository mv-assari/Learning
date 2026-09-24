namespace InitWebApi.Models.Entities.Dtos
{
    public class LoginDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public User User { get; set; }
    }
}
