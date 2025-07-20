using Dapper;
using send_training_backend.Controllers;
using send_training_backend.Models;
using System.Data;

namespace send_training_backend.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public UserRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }

        public UserEntity[] GetAllUsers()
        {
            var res = _dbConnection.Query<UserEntity>("SELECT * FROM Users");

            return res.ToArray();
        }

        public UserEntity GetUserById(int id)
        {
            var parameters = new { Id = id };
            var sql = "SELECT * FROM Users WHERE id = @Id";
            var res = _dbConnection.Query<UserEntity>(sql, parameters).FirstOrDefault();
            return res;
        }

        public UserEntity GetUserByEmail(string email)
        {
            var parameters = new { Email = email };
            var sql = "SELECT * FROM Users Where email = @Email";
            var res = _dbConnection.Query<UserEntity>(sql, parameters).FirstOrDefault();
            return res;
        }

        public UserEntity GetUserByUsername(string username)
        {
            var parameters = new { UserName = username };
            var sql = "SELECT * FROM Users WHERE username = @UserName";
            var res = _dbConnection.Query<UserEntity>(sql, parameters).FirstOrDefault();
            return res;
        }

        public UserEntity[] GetAllPoints()
        {
            var res = _dbConnection.Query<UserEntity>("SELECT points FROM Users");
            return res.ToArray();
        }

        public UserEntity[] GetAllUsernames()
        {
            var res = _dbConnection.Query<UserEntity>("SELECT username FROM Users");
            return res.ToArray();
        }

        public UserEntity[] GetAllHardestGrade()
        {
            var res = _dbConnection.Query<UserEntity>("SELECT grade FROM Users");
            return res.ToArray();
        }
    }
}
