using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CryptoService : ICryptoService
    {
        private const string SecretKey = "TOUCHCONSULTING2025";

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

        public bool Compare(string plainText, string hashedText)
        {
            var hashedPlainText = Encrypt(plainText);
            return hashedPlainText == hashedText;
        }
    }
}
