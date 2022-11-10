﻿namespace Web.Dtos
{
    public class InputUserRegistrationDto
    {
        public string Telephone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Login { get; set; } = null!;
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string? City { get; set; }
    }
}
