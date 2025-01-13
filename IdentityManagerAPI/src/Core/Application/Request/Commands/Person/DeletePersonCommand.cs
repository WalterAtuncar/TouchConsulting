using MediatR;

namespace Application.Request.Commands.Person
{
    public class DeletePersonCommand : IRequest<bool>
    {
        public int PersonId { get; set; }
        public string DeletedBy { get; set; } = null!;

        public DeletePersonCommand(int personId, string deletedBy)
        {
            PersonId = personId;
            DeletedBy = deletedBy;
        }
    }
} 