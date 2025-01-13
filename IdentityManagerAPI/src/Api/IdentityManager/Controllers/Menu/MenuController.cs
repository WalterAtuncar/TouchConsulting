using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Queries.Menu;
using Application.Request.Commands.Menu;
using Domain.Entities;
using Application.Common.Models;
using Application.Common.Models.Pagination;
using Infrastructure.RoleAuthorization;

namespace IdentityManager.Controllers.Menu
{
    /// <summary>
    /// Controlador para la gestión de menús en el sistema
    /// </summary>
    public class MenuController : SecureBaseApiController
    {
        public MenuController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de menús registrados en el sistema
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de menús disponibles en el sistema.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.Menu>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.Menu>>>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var query = new GetMenusQuery { Page = page, PageSize = pageSize };
                var response = await _mediator.Send(query);
                
                if (!response.Items.Any())
                    return ApiError<PaginatedResponse<Domain.Entities.Menu>>("No se encontraron menús", StatusCodes.Status404NotFound);

                return ApiResponse(response, "Menús obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.Menu>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene un menú por su identificador
        /// </summary>
        /// <param name="id">Identificador del menú</param>
        /// <returns>Información detallada del menú</returns>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Menu>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Menu>>> GetById(int id)
        {
            try
            {
                var menu = await _mediator.Send(new GetMenuByIdQuery(id));

                if (menu == null)
                    return ApiError<Domain.Entities.Menu>("Menú no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(menu, "Menú obtenido exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Menu>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea un nuevo menú en el sistema
        /// </summary>
        /// <param name="command">Datos del menú a crear</param>
        /// <returns>ID del menú creado</returns>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<int>>> Create([FromBody] CreateMenuCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<int>("Datos inválidos", StatusCodes.Status400BadRequest);

                var menuId = await _mediator.Send(command);
                return ApiResponse(menuId, "Menú creado exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<int>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza un menú existente
        /// </summary>
        /// <param name="id">ID del menú a actualizar</param>
        /// <param name="command">Datos actualizados del menú</param>
        /// <returns>True si se actualizó correctamente</returns>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Update(int id, [FromBody] UpdateMenuCommand command)
        {
            try
            {
                if (id != command.MenuId)
                    return ApiError<bool>("El ID del menú no coincide con el ID de la ruta", StatusCodes.Status400BadRequest);

                if (!ModelState.IsValid)
                    return ApiError<bool>("Datos inválidos", StatusCodes.Status400BadRequest);

                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Menú no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Menú actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente un menú
        /// </summary>
        /// <param name="id">ID del menú a eliminar</param>
        /// <param name="deletedBy">Usuario que realiza la eliminación</param>
        /// <returns>True si se eliminó correctamente</returns>
        [HttpDelete("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Delete(int id, [FromQuery] string deletedBy)
        {
            try
            {
                var command = new DeleteMenuCommand(id, deletedBy);
                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Menú no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Menú eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 