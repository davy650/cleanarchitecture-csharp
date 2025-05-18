using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IUserRepository
    {
        // Define user repository methods here
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);
    }
}