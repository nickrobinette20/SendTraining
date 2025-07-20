using Microsoft.AspNetCore.Identity;
using send_training_backend.DTO;
using send_training_backend.Models;

namespace send_training_backend.DTOs
{
    public class UserDTO
    {
        public int id {  get; set; }    
        public string name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public int points { get; set; }
        public BolderGreadesEnum grade { get; set; }

        public UserDTO(UserEntity user) {
            this.id = user.id;
            this.name = user.name;
            this.email = user.email;
            this.username = user.username;
            this.age = user.age;
            this.points = user.points;
            this.grade = user.grade;

        }

    }
}
