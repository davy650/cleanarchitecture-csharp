using CleanArchitecture.Application.Interfaces;

namespace CleanArchitecture.Infrastructure.Security
{
    // Your code will go here
    public class PasswordHasher : IPasswordHasher
    {
        public string Hash(string password)
        {
            // Implement your hashing logic here
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}