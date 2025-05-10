using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.Utils
{
    public static class PasswordHasher
    {
        public static (string Hash, string Salt) HashPassword(string password, int iterations = 10000) {
            // Generate salt
            byte[] saltBytes = RandomNumberGenerator.GetBytes(16);

            // Hash password with the salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);

            return (Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
        }

        public static bool VerifyPassword(string password, string hash, string salt, int iterations = 10000)
        {
            // Convert from Base64 string
            byte[] saltBytes = Convert.FromBase64String(salt);

            // Hash the password with the original salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);

            // Compare hash
            return Convert.ToBase64String(hashBytes) == hash;
        }
    }
}
