using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace ProyectoFinalBasedatos
{
    internal class SeguridadPasswort
    {
        public static string GenerarSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }


        public static string GenerarHash(string contrasena, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);
            using (var pbkdf2 = new Rfc2898DeriveBytes(contrasena, saltBytes, 10000, HashAlgorithmName.SHA256))
            {
                return Convert.ToBase64String(pbkdf2.GetBytes(32));
            }
        }
    }
}
