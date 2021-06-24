using System;
using System.Collections.Generic;
using System.Linq;
using ComputerHardwareStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardwareStore.DB
{
    public class ItemRepositoryDb : IItemRepository
    {
        private readonly ItemContext _itemContext;

        public ItemRepositoryDb(ItemContext itemContext)
        {
            _itemContext = itemContext;
        }
        public IEnumerable<Item> GetAllItems()
        {
            return _itemContext.Items.ToList();
        }

        public Item GetItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}