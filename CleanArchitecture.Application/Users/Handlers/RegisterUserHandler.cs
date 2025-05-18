using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Users.Commands;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Users.Handlers
{
    // Your code will go here,
    public class RegisterUserHandler
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public RegisterUserHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task Handle(RegisterUserCommand command)
        {
            var existingUser = await _userRepository.GetByEmailAsync(command.Email);
            if (existingUser != null)
            {
                throw new Exception("User already exists.");
            }

            var hashedPassword = _passwordHasher.Hash(command.Password);
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Email = command.Email,
                PasswordHash = hashedPassword
            };

            await _userRepository.AddAsync(newUser);
        }
    }
}