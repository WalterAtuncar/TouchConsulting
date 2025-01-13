using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace IdentityManager.Controllers
{
    [Authorize]
    public abstract class SecureBaseApiController : BaseApiController
    {
        protected SecureBaseApiController(IMediator mediator) : base(mediator)
        {
        }

        protected string GetCurrentUser()
        {
            var uniqueNameClaim = User.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name");
            return uniqueNameClaim?.Value ?? "system";
        }

        /// <summary>
        /// Establece el usuario actual en un comando que requiere CreatedBy o UpdatedBy
        /// </summary>
        protected void SetCurrentUser<TCommand>(TCommand command) where TCommand : class
        {
            var currentUser = GetCurrentUser();
            var property = command.GetType().GetProperty("CreatedBy") ?? command.GetType().GetProperty("UpdatedBy") ?? command.GetType().GetProperty("DeletedBy");

            if (property != null && property.CanWrite)
            {
                property.SetValue(command, currentUser);
            }
        }
    }
} 