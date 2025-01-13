using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Queries.RoleMenu;
using Application.Request.Commands.RoleMenu;
using Domain.Entities;
using Application.Common.Models;
using Application.Common.Models.Pagination;
using Infrastructure.RoleAuthorization;

namespace IdentityManager.Controllers.RoleMenu
{
    /// <summary>
    /// Controlador para la gestión de asignaciones de menús a roles en el sistema
    /// </summary>
    public class RoleMenuController : BaseApiController
    {
        public RoleMenuController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de asignaciones de menús a roles
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de asignaciones de menús a roles en el sistema.
        /// Se puede filtrar por RoleId y/o MenuId.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.RoleMenu>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.RoleMenu>>>> GetAll(
            [FromQuery] int? roleId,
            [FromQuery] int? menuId,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            try
            {
                var query = new GetRoleMenusQuery 
                { 
                    RoleId = roleId,
                    MenuId = menuId,
                    Page = page,
                    PageSize = pageSize 
                };
                var response = await _mediator.Send(query);
                
                if (!response.Items.Any())
                    return ApiError<PaginatedResponse<Domain.Entities.RoleMenu>>("No se encontraron asignaciones de menús", StatusCodes.Status404NotFound);

                return ApiResponse(response, "Asignaciones de menús obtenidas exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.RoleMenu>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene una asignación de menú a rol por su identificador
        /// </summary>
        /// <param name="id">Identificador de la asignación</param>
        /// <returns>Información detallada de la asignación</returns>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.RoleMenu>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.RoleMenu>>> GetById(int id)
        {
            try
            {
                var roleMenu = await _mediator.Send(new GetRoleMenuByIdQuery(id));

                if (roleMenu == null)
                    return ApiError<Domain.Entities.RoleMenu>("Asignación de menú no encontrada", StatusCodes.Status404NotFound);

                return ApiResponse(roleMenu, "Asignación de menú obtenida exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.RoleMenu>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea una nueva asignación de menú a rol
        /// </summary>
        /// <param name="command">Datos de la asignación a crear</param>
        /// <returns>ID de la asignación creada</returns>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<int>>> Create([FromBody] CreateRoleMenuCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<int>("Datos inválidos", StatusCodes.Status400BadRequest);

                var roleMenuId = await _mediator.Send(command);
                return ApiResponse(roleMenuId, "Asignación de menú creada exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<int>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza una asignación de menú a rol existente
        /// </summary>
        /// <param name="id">ID de la asignación a actualizar</param>
        /// <param name="command">Datos actualizados de la asignación</param>
        /// <returns>True si se actualizó correctamente</returns>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Update(int id, [FromBody] UpdateRoleMenuCommand command)
        {
            try
            {
                if (id != command.RoleMenuId)
                    return ApiError<bool>("El ID de la asignación no coincide con el ID de la ruta", StatusCodes.Status400BadRequest);

                if (!ModelState.IsValid)
                    return ApiError<bool>("Datos inválidos", StatusCodes.Status400BadRequest);

                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Asignación de menú no encontrada", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Asignación de menú actualizada exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente una asignación de menú a rol
        /// </summary>
        /// <param name="id">ID de la asignación a eliminar</param>
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
                var command = new DeleteRoleMenuCommand(id, deletedBy);
                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Asignación de menú no encontrada", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Asignación de menú eliminada exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 