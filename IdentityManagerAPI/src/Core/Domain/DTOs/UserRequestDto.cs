namespace Domain.DTOs
{
    /// <summary>
    /// DTO para las credenciales de autenticación del usuario
    /// </summary>
    public class UserRequestDto
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
} 