namespace Module5HT1_Networking.Models
{
    using System;

    public class Register
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Guid Token { get; set; }

        public string Error { get; set; }
    }
}
