namespace ComplexTypesBinding.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Info Info { get; set; }
    }

    public class Info
    {
        public string Company { get; set; }
    }
}
