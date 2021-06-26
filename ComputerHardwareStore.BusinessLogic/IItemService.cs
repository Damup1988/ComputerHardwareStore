using System;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;
using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json.Serialization;

namespace ComputerHardwareStore.BusinessLogic
{
    public interface IItemService
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(Guid id);
        void CreateItem(Item item);
        bool UpdateItem(Item item);
        bool DeleteItem(Guid id);
    }
}