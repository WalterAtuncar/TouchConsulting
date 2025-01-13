namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el servicio de encriptación y comparación de contraseñas
    /// </summary>
    public interface ICryptoService
    {
        /// <summary>
        /// Encripta un texto usando SHA256 con una llave secreta
        /// </summary>
        /// <param name="text">Texto a encriptar</param>
        /// <returns>Texto encriptado en formato hexadecimal</returns>
        string Encrypt(string text);

        /// <summary>
        /// Compara un texto plano con un texto encriptado
        /// </summary>
        /// <param name="plainText">Texto plano a comparar</param>
        /// <param name="hashedText">Texto encriptado a comparar</param>
        /// <returns>True si los textos coinciden, False en caso contrario</returns>
        bool Compare(string plainText, string hashedText);
    }
} 