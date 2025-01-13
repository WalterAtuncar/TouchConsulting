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
    }
} 