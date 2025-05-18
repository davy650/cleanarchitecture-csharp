namespace CleanArchitecture.Domain.Entities
{
    // User entity implementation will go here. This is at the core of the implementation
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
    }
}