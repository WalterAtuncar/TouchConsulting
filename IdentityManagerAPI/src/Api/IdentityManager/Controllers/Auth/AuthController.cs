using MediatR;
using Microsoft.AspNetCore.Mvc;
using Domain.DTOs;
using Application.Common.Models;
using Application.Request.Commands.Auth;

namespace IdentityManager.Controllers.Auth
{
    /// <summary>
    /// Controlador para la autenticación de usuarios
    /// </summary>
    public class AuthController : BaseApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Autentica un usuario en el sistema
        /// </summary>
        /// <param name="credentials">Credenciales del usuario</param>
        /// <returns>Información del usuario autenticado, sus menús y token de acceso</returns>
        [HttpPost("login")]
        [ProducesResponseType(typeof(ApiResponse<LoginResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiResponse<LoginResponseDto>>> Login([FromBody] UserRequestDto credentials)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ApiError<LoginResponseDto>("Credenciales inválidas", StatusCodes.Status400BadRequest);

                var command = new LoginCommand(credentials);
                var response = await _mediator.Send(command);

                if (!response.Success)
                    return ApiError<LoginResponseDto>("Credenciales incorrectas", StatusCodes.Status400BadRequest);

                return ApiResponse(response, "Login exitoso");
            }
            catch (Exception ex)
            {
                return ApiError<LoginResponseDto>(ex.Message, StatusCodes.Status500InternalServerError);
            }
        }
    }
} 