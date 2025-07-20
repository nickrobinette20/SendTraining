namespace send_training_backend.DTOs
{
    public class RegisterDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string username  { get; set; }
        public int age { get; set; }

        public RegisterDTO() { }


    }
}
