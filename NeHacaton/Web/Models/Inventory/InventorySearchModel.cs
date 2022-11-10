﻿using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Web.Models.Inventory
{
    public class InventorySearchModel
    {
        public string? Search { get; set; }

        public string[]? Tags { get; set; } = null;

        public double? Lat { get; set; }

        public double? Lon { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }

        public string? City { get; set; }
    }
}
