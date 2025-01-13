using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Queries.Category;
using Application.Common.Models;
using Application.Common.Models.Pagination;
using Infrastructure.RoleAuthorization;

namespace ProductManagement.Controllers.Category
{
    /// <summary>
    /// Controlador para la gestión de categorías en el sistema
    /// </summary>
    public class CategoryController : SecureBaseApiController
    {
        public CategoryController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de categorías registradas en el sistema
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de categorías disponibles en el sistema.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.Category>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.Category>>>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var query = new GetCategoriesQuery { Page = page, PageSize = pageSize };
                var response = await _mediator.Send(query);
                
                if (!response.Items.Any())
                    return ApiError<PaginatedResponse<Domain.Entities.Category>>("No se encontraron categorías", StatusCodes.Status404NotFound);

                return ApiResponse(response, "Categorías obtenidas exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.Category>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 