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
            return _repository.GetItemById(id);
        }

        public void CreateItem(Item item)
        {
            _repository.CreateItem(item);
            _repository.SaveChangesFunc();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            _repository.DeleteItem(id);
            _repository.SaveChangesFunc();
        }
    }
}