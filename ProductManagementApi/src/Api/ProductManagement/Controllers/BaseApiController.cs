using Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        protected readonly IMediator _mediator;

        protected BaseApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected ActionResult<ApiResponse<T>> ApiResponse<T>(T data, string message = "Operación exitosa", int statusCode = 200)
        {
            var response = Application.Common.Models.ApiResponse<T>.Success(data, message, statusCode);
            return StatusCode(statusCode, response);
        }

        protected ActionResult<ApiResponse<T>> ApiError<T>(string message, int statusCode)
        {
            var response = Application.Common.Models.ApiResponse<T>.Fail(message, statusCode);
            return StatusCode(statusCode, response);
        }
    }
}
