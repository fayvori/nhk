﻿using Newtonsoft.Json;

namespace Web.Dtos.UserSelfInfoDto.Rent
{
    public class OutputStateDto
    {
        public string Title { get; set; } = null!;
        public string? TextColor { get; set; }
        public string? Color { get; set; }
        public string? @Const { get; set; }
    }
}
