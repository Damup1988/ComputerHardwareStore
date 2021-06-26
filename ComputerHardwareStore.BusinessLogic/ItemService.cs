using System;
using System.Collections.Generic;
using AutoMapper;
using ComputerHardwareStore.DB;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.BusinessLogic
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public IEnumerable<Item> GetAllItems()
        {
            return _repository.GetAllItems();
        }

        public Item GetItemById(Guid id)
        {
            var item = _repository.GetItemById(id);
            return item != null ? _repository.GetItemById(id) : null;
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