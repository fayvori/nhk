﻿using Web.Dtos.Sales.Inventory;

namespace Web.Search.Inventory
{
    public interface InventoryTagSearcher
    {
        bool TagsAreContained(string[]? tags, string? text);

        IEnumerable<OutputInventoryDto> SelectInventoriesByTags(string[]? tags, IEnumerable<OutputInventoryDto> inventories);
    }
}
