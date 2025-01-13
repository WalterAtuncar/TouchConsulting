using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Domain.DTOs;
using Domain.Interfaces;

namespace Infrastructure.Services
{
    /// <summary>
    /// Implementación del servicio de generación de tokens JWT
    /// </summary>
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Genera un token JWT para un usuario
        /// </summary>
        /// <param name="user">Datos del usuario</param>
        /// <returns>Token JWT generado</returns>
        public string GenerateToken(UserDto user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                new Claim(ClaimTypes.Role, GetRoleString(user.RoleId)),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(1);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        /// <summary>
        /// Convierte el ID del rol a su representación en string
        /// </summary>
        /// <param name="roleId">ID del rol</param>
        /// <returns>Nombre del rol</returns>
        private string GetRoleString(int roleId)
        {
            return roleId switch
            {
                1 => "Admin",
                2 => "Doctor",
                3 => "Patient",
                _ => string.Empty
            };
        }
    }
} 