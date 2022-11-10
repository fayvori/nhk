﻿using Newtonsoft.Json;

namespace HendInRentApi.Dto.Inventory
{
    public class InputHIRAInventoryDto
    {
        [JsonProperty("search")]
        public string? Search { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }
        
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        [JsonProperty("rent_number")]
        public string? RentNumber { get; set; }
        
        [JsonProperty("state_id")]
        public int? StateId { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("offset")]
        public int? Offset { get; set; }

        public InputHIRADiscountsDto? Discounts { get; set; }
    }
}
