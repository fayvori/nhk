﻿using Newtonsoft.Json;

namespace HendInRentApi.Dto.Inventory
{
    public class OutputHIRAResourceDto
    {
        public int Id { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string? Body { get; set; }

        [JsonProperty("dict_id")]
        public int DictId { get; set; }

        [JsonProperty("controller_id")]
        public int ControllerId { get; set; }

        [JsonProperty("deleted_at")]
        public DateTime DeletedAt { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        public string? @Const { get; set; }
    }
}
