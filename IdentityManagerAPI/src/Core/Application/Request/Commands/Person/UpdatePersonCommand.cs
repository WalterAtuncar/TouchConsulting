using MediatR;

namespace Application.Request.Commands.Person
{
    public class UpdatePersonCommand : IRequest<bool>
    {
        public int PersonId { get; set; }
        public string Names { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Img { get; set; }
        public string? Email { get; set; }
        public string? UpdatedBy { get; set; }
    }
} 