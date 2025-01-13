using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Common.Models;
using Application.Request.Queries.Category;
using Application.Request.Commands.Category;
using Infrastructure.RoleAuthorization;
using Application.Common.Models.Pagination;

namespace ProductManagement.Controllers.Category
{
    /// <summary>
    /// Controlador para la gestión de categorías en el sistema
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : SecureBaseApiController
    {
        public CategoryController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de categorías registradas en el sistema
        /// </summary>
        /// <param name="query">Parámetros de paginación</param>
        /// <returns>Lista paginada de categorías</returns>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de categorías disponibles en el sistema.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin", "User")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.Category>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.Category>>>> GetAll([FromQuery] GetCategoriesQuery query)
        {
            try
            {
                var categories = await _mediator.Send(query);

                if (categories == null || categories.Items.ToList().Count == 0)
                    return ApiError<PaginatedResponse<Domain.Entities.Category>>("No se encontraron categorías", StatusCodes.Status404NotFound);

                return ApiResponse(categories, "Categorías obtenidas exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.Category>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene una categoría específica por su ID
        /// </summary>
        /// <param name="id">ID de la categoría a buscar</param>
        /// <returns>Categoría encontrada</returns>
        /// <remarks>
        /// Este endpoint retorna una categoría específica basada en el ID proporcionado.
        /// </remarks>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin", "User")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Category>>> GetById(int id)
        {
            try
            {
                var query = new GetCategoryByIdQuery(id);
                var category = await _mediator.Send(query);

                if (category == null)
                    return ApiError<Domain.Entities.Category>("No se encontró la categoría", StatusCodes.Status404NotFound);

                return ApiResponse(category, "Categoría obtenida exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Category>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea una nueva categoría en el sistema
        /// </summary>
        /// <param name="command">Datos de la categoría a crear</param>
        /// <returns>Categoría creada</returns>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Category>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Category>>> Create([FromBody] CreateCategoryCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<Domain.Entities.Category>("Datos de categoría inválidos", StatusCodes.Status400BadRequest);

                SetCurrentUser(command);
                var category = await _mediator.Send(command);
                return ApiResponse(category, "Categoría creada exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Category>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza una categoría existente
        /// </summary>
        /// <param name="id">ID de la categoría a actualizar</param>
        /// <param name="command">Datos actualizados de la categoría</param>
        /// <returns>Categoría actualizada</returns>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Category>>> Update(int id, [FromBody] UpdateCategoryCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<Domain.Entities.Category>("Datos de categoría inválidos", StatusCodes.Status400BadRequest);

                command.CategoryId = id;
                SetCurrentUser(command);
                
                var category = await _mediator.Send(command);

                if (category == null)
                    return ApiError<Domain.Entities.Category>("No se encontró la categoría", StatusCodes.Status404NotFound);

                return ApiResponse(category, "Categoría actualizada exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Category>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente una categoría del sistema
        /// </summary>
        /// <param name="id">ID de la categoría a eliminar</param>
        /// <returns>Categoría eliminada</returns>
        /// <remarks>
        /// Este endpoint realiza un eliminado lógico de la categoría especificada.
        /// El usuario que realiza la eliminación se obtiene automáticamente del token JWT.
        /// </remarks>
        [HttpDelete("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Category>>> Delete(int id)
        {
            try
            {
                var command = new DeleteCategoryCommand { CategoryId = id };
                SetCurrentUser(command);
                
                var category = await _mediator.Send(command);

                if (category == null)
                    return ApiError<Domain.Entities.Category>("No se encontró la categoría", StatusCodes.Status404NotFound);

                return ApiResponse(category, "Categoría eliminada exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Category>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 