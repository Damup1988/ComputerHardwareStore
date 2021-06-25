using System;
using System.Collections;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.DB
{
    public interface IItemRepository
    {
        bool SaveChangesFunc();
        IEnumerable<Item> GetAllItems();
        Item GetItemById(Guid id);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}