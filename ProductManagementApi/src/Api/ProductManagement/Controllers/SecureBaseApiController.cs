using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Common.Models;

namespace ProductManagement.Controllers
{
    public abstract class SecureBaseApiController : BaseApiController
    {
        protected SecureBaseApiController(IMediator mediator) : base(mediator)
        {
        }

        protected string GetCurrentUser()
        {
            return "system"; // Temporalmente retornamos un valor fijo
        }

        protected void SetCurrentUser<TCommand>(TCommand command) where TCommand : class
        {
            var currentUser = GetCurrentUser();
            var property = command.GetType().GetProperty("CreatedBy") ?? command.GetType().GetProperty("UpdatedBy");
            
            if (property != null && property.CanWrite)
            {
                property.SetValue(command, currentUser);
            }
        }
    }
}
