namespace Domain.DTOs
{
    /// <summary>
    /// DTO para transferencia de datos de usuario
    /// </summary>
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Img { get; set; }
        public int RoleId { get; set; }
        public bool IsDeleted { get; set; }
        public int PersonId { get; set; }
    }
} 