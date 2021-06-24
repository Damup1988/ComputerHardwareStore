using System;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.BusinessLogic
{
    public interface IItemService
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(Guid id);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Item item);
    }
}