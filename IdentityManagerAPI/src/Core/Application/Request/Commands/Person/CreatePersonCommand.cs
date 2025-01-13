using MediatR;

namespace Application.Request.Commands.Person
{
    public class CreatePersonCommand : IRequest<int>
    {
        public string Names { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Img { get; set; }
        public string? Email { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
} 