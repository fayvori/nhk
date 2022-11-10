﻿using System.Text.Json.Serialization;

namespace HendInRentApi.Dto.Inventory
{ 
    

    public class OutputHIRAPermissionDto
    {
        [JsonPropertyName("resource_id")]
        public int ResourceId { get; set; }

        public bool Delete { get; set; }

        public bool Read { get; set; }

        public bool Write { get; set; }

        public bool Right { get; set; }
    }
    

}
