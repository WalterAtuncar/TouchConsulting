using System.Security.Cryptography;
using System.Text;
using Domain.Interfaces;

namespace Infrastructure.Services
{
    /// <summary>
    /// Implementación del servicio de encriptación y comparación de contraseñas
    /// </summary>
    public class CryptoService : ICryptoService
    {
        private const string SecretKey = "OMEGANETPERU2025";

        /// <summary>
        /// Encripta un texto usando SHA256 con una llave secreta
        /// </summary>
        /// <param name="text">Texto a encriptar</param>
        /// <returns>Texto encriptado en formato hexadecimal</returns>
        public string Encrypt(string text)
        {
            try
            {
                using (var sha256 = SHA256.Create())
                {
                    var textBytes = Encoding.UTF8.GetBytes(SecretKey + text);
                    var hashBytes = sha256.ComputeHash(textBytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Encryption failed: {ex.Message}");
            }
        }

        /// <summary>
        /// Compara un texto plano con un texto encriptado
        /// </summary>
        /// <param name="plainText">Texto plano a comparar</param>
        /// <param name="hashedText">Texto encriptado a comparar</param>
        /// <returns>True si los textos coinciden, False en caso contrario</returns>
        public bool Compare(string plainText, string hashedText)
        {
            var hashedPlainText = Encrypt(plainText);
            return hashedPlainText == hashedText;
        }
    }
} 