using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace ProductManagement.Controllers
{
    [Authorize]
    public abstract class SecureBaseApiController : BaseApiController
    {
        protected SecureBaseApiController(IMediator mediator) : base(mediator)
        {
        }
    }
}
