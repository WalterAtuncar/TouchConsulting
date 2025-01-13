using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.Common.Models;

namespace ProductManagement.Controllers
{
    [Authorize]
    public abstract class SecureBaseApiController : BaseApiController
    {
        protected SecureBaseApiController(IMediator mediator) : base(mediator)
        {
        }
        /// <summary>
        /// Obtiene el nombre de usuario desde el claim 'unique_name' del token JWT
        /// </summary>
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
            var property = command.GetType().GetProperty("CreatedBy") ?? command.GetType().GetProperty("UpdatedBy");
            
            if (property != null && property.CanWrite)
            {
                property.SetValue(command, currentUser);
            }
        }
    }
}
