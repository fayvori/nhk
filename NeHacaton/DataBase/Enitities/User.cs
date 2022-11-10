﻿namespace DataBase.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string City { get; set; } = null!;

        public void ChangeCity(string city)
        {
            if (string.IsNullOrEmpty(city))
                throw new InvalidOperationException("City cannot be null or empty");
            City = city.ToLower();
        }
    }    
}
