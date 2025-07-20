using send_training_backend.Models;

namespace send_training_backend.Repository
{
    public interface IUserRepository
    {
        public UserEntity[] GetAllUsers();
        public UserEntity GetUserById(int id);
        public UserEntity GetUserByEmail(string email);
        public UserEntity GetUserByUsername(string username);
        public UserEntity[] GetAllPoints();
        public UserEntity[] GetAllUsernames();
        public UserEntity[] GetAllHardestGrade();
    }
}
