using send_training_backend.Models;
using send_training_backend.Repository;

namespace send_training_backend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _iUserRepository;

        public UserService(IUserRepository iUserRepository)
        {
            this._iUserRepository = iUserRepository;
        }

        public UserEntity[] GetAllUsers()
        {
            var users = _iUserRepository.GetAllUsers();
            return users.ToArray();
        }
        public UserEntity GetUserById(int id) 
        { 
            var user = _iUserRepository.GetUserById(id);
            return user;
        }

        public UserEntity GetUserByEmail(String email)
        {
            var user = _iUserRepository.GetUserByEmail(email);
            return user;
        }
        public UserEntity GetUserByUsername(String username) 
        { 
            var user = _iUserRepository.GetUserByUsername(username);
            return user;
        
        }
        public UserEntity[] GetAllPoints() 
        { 
            var users = _iUserRepository.GetAllPoints();
            return users.ToArray();
        
        }
        public UserEntity[] GetAllUsernames() 
        {
            var users = _iUserRepository.GetAllUsernames();
            return users.ToArray();
        
        }
        public UserEntity[] GetAllHardestGrade()
        {
            var users = _iUserRepository.GetAllHardestGrade();
            return users.ToArray();
        }

        
    }
}
