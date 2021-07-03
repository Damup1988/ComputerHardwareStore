using System;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.DB.Items
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(Guid id);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}