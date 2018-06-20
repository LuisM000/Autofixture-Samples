using System;
namespace AutofixtureSamples
{
    public class User
    {
        public string Name { get; }
        public string Password { get;}
        public string Email { get; }
        public Country Country { get; set; } 
        public DateTime BornDate { get; set; }

        public Product Product { get; set; }

        public User(string name, string password, string email)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("must be at least one character", nameof(name));
            if (string.IsNullOrEmpty(password) || password.Length < 4 || password.Length > 12)
                throw new ArgumentException("must be between 4 and 12 characters", nameof(password));
            if(!Validator.EmailIsValid(email))
                throw new ArgumentException("wrong email address formats", nameof(email));

            this.Name = name;
            this.Password = password;
            this.Email = email;
        }

        public bool? IsAdult()
        {
            if (this.Country?.Name == "ES" && DateTime.Today.Year - this.BornDate.Year >= 18)//Esta comprobación no tiene muy buena pinta
                return true;
            return false;
        }
    }
}
