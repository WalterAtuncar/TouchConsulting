namespace Domain.DTOs
{
    public class LoginResponseDto
    {
        public bool Success { get; set; }
        public LoginDataDto? Data { get; set; }
    }

    public class LoginDataDto
    {
        public UserDto User { get; set; } = null!;
        public List<MenuResponseDto> Menus { get; set; } = new List<MenuResponseDto>();
        public string Token { get; set; } = null!;
    }
} 