using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Request.Queries.Person;
using Application.Request.Commands.Person;
using Domain.Entities;
using Application.Common.Models;
using Application.Common.Models.Pagination;
using Infrastructure.RoleAuthorization;

namespace IdentityManager.Controllers.Person
{
    /// <summary>
    /// Controlador para la gestión de personas en el sistema
    /// </summary>
    public class PersonController : SecureBaseApiController
    {
        public PersonController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Obtiene la lista paginada de personas registradas en el sistema
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna una lista paginada de personas disponibles en el sistema.
        /// </remarks>
        [HttpGet]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedResponse<Domain.Entities.Person>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<PaginatedResponse<Domain.Entities.Person>>>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var query = new GetPersonsQuery { Page = page, PageSize = pageSize };
                var response = await _mediator.Send(query);
                
                if (!response.Items.Any())
                    return ApiError<PaginatedResponse<Domain.Entities.Person>>("No se encontraron personas", StatusCodes.Status404NotFound);

                return ApiResponse(response, "Personas obtenidas exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<PaginatedResponse<Domain.Entities.Person>>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Obtiene una persona por su identificador
        /// </summary>
        /// <param name="id">Identificador de la persona</param>
        /// <returns>Información detallada de la persona</returns>
        [HttpGet("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<Domain.Entities.Person>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<Domain.Entities.Person>>> GetById(int id)
        {
            try
            {
                var person = await _mediator.Send(new GetPersonByIdQuery(id));

                if (person == null)
                    return ApiError<Domain.Entities.Person>("Persona no encontrada", StatusCodes.Status404NotFound);

                return ApiResponse(person, "Persona obtenida exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<Domain.Entities.Person>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Crea una nueva persona en el sistema
        /// </summary>
        /// <param name="command">Datos de la persona a crear</param>
        /// <returns>ID de la persona creada</returns>
        [HttpPost]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<int>>> Create([FromBody] CreatePersonCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<int>("Datos inválidos", StatusCodes.Status400BadRequest);

                var personId = await _mediator.Send(command);
                return ApiResponse(personId, "Persona creada exitosamente", StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return ApiError<int>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Actualiza una persona existente
        /// </summary>
        /// <param name="id">ID de la persona a actualizar</param>
        /// <param name="command">Datos actualizados de la persona</param>
        /// <returns>True si se actualizó correctamente</returns>
        [HttpPut("{id}")]
        [TouchAuthorization("Admin")]
        [ProducesResponseType(typeof(ApiResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<bool>>> Update(int id, [FromBody] UpdatePersonCommand command)
        {
            try
            {
                if (id != command.PersonId)
                    return ApiError<bool>("El ID de la persona no coincide con el ID de la ruta", StatusCodes.Status400BadRequest);

                if (!ModelState.IsValid)
                    return ApiError<bool>("Datos inválidos", StatusCodes.Status400BadRequest);

                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Persona no encontrada", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Persona actualizada exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Elimina lógicamente una persona
        /// </summary>
        /// <param name="id">ID de la persona a eliminar</param>
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
                var command = new DeletePersonCommand(id, deletedBy);
                var result = await _mediator.Send(command);

                if (!result)
                    return ApiError<bool>("Persona no encontrada", StatusCodes.Status404NotFound);

                return ApiResponse(result, "Persona eliminada exitosamente");
            }
            catch (Exception ex)
            {
                return ApiError<bool>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 