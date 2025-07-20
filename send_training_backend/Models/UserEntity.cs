using send_training_backend.DTO;

namespace send_training_backend.Models
{
    public class UserEntity
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int points { get; set; }
        public BolderGreadesEnum grade { get; set; }
        public string email {  get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string passwordKey { get; set; }

        public UserEntity(int id, string name, int age, int points, BolderGreadesEnum grade, string email, string username, string password, string passwordKey)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.points = points;
            this.grade = grade;
            this.email = email;
            this.username = username;
            this.password = password;
            this.passwordKey = passwordKey;
        }

        public UserEntity()
        {
        }


    }
}
