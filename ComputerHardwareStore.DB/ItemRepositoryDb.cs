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

        public bool SaveChangesFunc()
        {
            return (_itemContext.SaveChanges() >= 0);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _itemContext.Items.ToList();
        }

        public Item GetItemById(Guid id)
        {
            return _itemContext.Items.FirstOrDefault(p => p.Id == id);
        }

        public void CreateItem(Item item)
        {
            _itemContext.Items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            var item = GetItemById(id);
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            else
            {
                _itemContext.Items.Remove(item);
            }
        }
    }
}