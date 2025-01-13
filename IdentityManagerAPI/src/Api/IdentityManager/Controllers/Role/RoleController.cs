using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Queries.Role;
using Application.Request.Commands.Role;
using Domain.Entities;
using Application.Common.Models;
using Application.Common.Models.Pagination;
using Infrastructure.RoleAuthorization;

namespace IdentityManager.Controllers.Role
{
    /// <summary>
    /// Controlador para la gestión de roles en el sistema
    /// </summary>
    public class RoleController : SecureBaseApiController
    {
        public RoleController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de roles registrados en el sistema
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de roles disponibles en el sistema.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.Role>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.Role>>>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var query = new GetRolesQuery { Page = page, PageSize = pageSize };
                var response = await _mediator.Send(query);
                
                if (!response.Items.Any())
                    return ApiError<PaginatedResponse<Domain.Entities.Role>>("No se encontraron roles", StatusCodes.Status404NotFound);

                return ApiResponse(response, "Roles obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.Role>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene un rol por su identificador
        /// </summary>
        /// <param name="id">Identificador del rol</param>
        /// <returns>Información detallada del rol</returns>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Role>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Role>>> GetById(int id)
        {
            try
            {
                var role = await _mediator.Send(new GetRoleByIdQuery(id));

                if (role == null)
                    return ApiError<Domain.Entities.Role>("Rol no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(role, "Rol obtenido exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Role>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea un nuevo rol en el sistema
        /// </summary>
        /// <param name="command">Datos del rol a crear</param>
        /// <returns>ID del rol creado</returns>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<int>>> Create([FromBody] CreateRoleCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<int>("Datos inválidos", StatusCodes.Status400BadRequest);
                SetCurrentUser(command);
                var roleId = await _mediator.Send(command);
                return ApiResponse(roleId, "Rol creado exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<int>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza un rol existente
        /// </summary>
        /// <param name="id">ID del rol a actualizar</param>
        /// <param name="command">Datos actualizados del rol</param>
        /// <returns>True si se actualizó correctamente</returns>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Update(int id, [FromBody] UpdateRoleCommand command)
        {
            try
            {
                if (id != command.RoleId)
                    return ApiError<bool>("El ID del rol no coincide con el ID de la ruta", StatusCodes.Status400BadRequest);

                if (!ModelState.IsValid)
                    return ApiError<bool>("Datos inválidos", StatusCodes.Status400BadRequest);
                SetCurrentUser(command);
                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Rol no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Rol actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente un rol
        /// </summary>
        /// <param name="id">ID del rol a eliminar</param>
        /// <param name="deletedBy">Usuario que realiza la eliminación</param>
        /// <returns>True si se eliminó correctamente</returns>
        [HttpDelete("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Delete(int id)
        {
            try
            {
                var command = new DeleteRoleCommand(id, null);
                SetCurrentUser(command);
                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Rol no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Rol eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 