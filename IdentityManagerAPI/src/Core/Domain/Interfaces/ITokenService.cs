using Domain.DTOs;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el servicio de generación de tokens JWT
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// Genera un token JWT para un usuario
        /// </summary>
        /// <param name="user">Datos del usuario</param>
        /// <returns>Token JWT generado</returns>
        string GenerateToken(UserDto user);
    }
} 