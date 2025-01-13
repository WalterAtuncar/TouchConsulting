using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Queries.User;
using Application.Request.Commands.User;
using Domain.Entities;
using Application.Common.Models;
using Application.Common.Models.Pagination;
using Infrastructure.RoleAuthorization;

namespace IdentityManager.Controllers.User
{
    /// <summary>
    /// Controlador para la gestión de usuarios en el sistema
    /// </summary>
    public class UserController : SecureBaseApiController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de usuarios
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de usuarios registrados en el sistema.
        /// Se puede filtrar por RoleId, PersonId y/o Username.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.User>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.User>>>> GetAll(
            [FromQuery] int? roleId,
            [FromQuery] int? personId,
            [FromQuery] string? username,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            try
            {
                var query = new GetUsersQuery 
                { 
                    RoleId = roleId,
                    PersonId = personId,
                    Username = username,
                    Page = page,
                    PageSize = pageSize 
                };
                var response = await _mediator.Send(query);
                
                if (!response.Items.Any())
                    return ApiError<PaginatedResponse<Domain.Entities.User>>("No se encontraron usuarios", StatusCodes.Status404NotFound);

                return ApiResponse(response, "Usuarios obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.User>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene un usuario por su identificador
        /// </summary>
        /// <param name="id">Identificador del usuario</param>
        /// <returns>Información detallada del usuario</returns>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.User>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.User>>> GetById(int id)
        {
            try
            {
                var user = await _mediator.Send(new GetUserByIdQuery(id));

                if (user == null)
                    return ApiError<Domain.Entities.User>("Usuario no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(user, "Usuario obtenido exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.User>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea un nuevo usuario en el sistema
        /// </summary>
        /// <param name="command">Datos del usuario a crear</param>
        /// <returns>ID del usuario creado</returns>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<int>>> Create([FromBody] CreateUserCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<int>("Datos inválidos", StatusCodes.Status400BadRequest);

                var userId = await _mediator.Send(command);
                return ApiResponse(userId, "Usuario creado exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<int>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza un usuario existente
        /// </summary>
        /// <param name="id">ID del usuario a actualizar</param>
        /// <param name="command">Datos actualizados del usuario</param>
        /// <returns>True si se actualizó correctamente</returns>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Update(int id, [FromBody] UpdateUserCommand command)
        {
            try
            {
                if (id != command.UserId)
                    return ApiError<bool>("El ID del usuario no coincide con el ID de la ruta", StatusCodes.Status400BadRequest);

                if (!ModelState.IsValid)
                    return ApiError<bool>("Datos inválidos", StatusCodes.Status400BadRequest);

                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Usuario no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Usuario actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente un usuario
        /// </summary>
        /// <param name="id">ID del usuario a eliminar</param>
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
                var command = new DeleteUserCommand(id, deletedBy);
                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Usuario no encontrado", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Usuario eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 