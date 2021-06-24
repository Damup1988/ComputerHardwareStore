using System;
using System.Collections.Generic;
using ComputerHardwareStore.DB;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.BusinessLogic
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<Item> GetAllItems()
        {
            return _repository.GetAllItems();
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