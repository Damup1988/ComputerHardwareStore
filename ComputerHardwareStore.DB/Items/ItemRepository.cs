using System;
using System.Collections.Generic;
using System.Linq;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.DB.Items
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemContext _itemContext;

        public ItemRepository(ItemContext itemContext)
        {
            _itemContext = itemContext;
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
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _itemContext.Items.Add(item);
            _itemContext.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            _itemContext.Items.Update(item);
            _itemContext.SaveChanges();
        }

        public void DeleteItem(Guid id)
        {
            _itemContext.Items.Remove(GetItemById(id));
            _itemContext.SaveChanges();
        }
    }
}