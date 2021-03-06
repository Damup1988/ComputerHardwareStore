using System;
using System.Collections.Generic;
using AutoMapper;
using ComputerHardwareStore.DB;
using ComputerHardwareStore.DB.Items;
using ComputerHardwareStore.Domain;
using ComputerHardwareStore.Domain.Enums;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        }

        public bool UpdateItem(Item item)
        {
            if (GetItemById(item.Id) != null)
            {
                _repository.UpdateItem(item);
                return true;
            }
            else return false;
        }

        public bool DeleteItem(Guid id)
        {
            var item = GetItemById(id);
            if (item != null)
            {
                _repository.DeleteItem(id);
                return true;
            }
            else return false;
        }

        private bool VeriftItemProperties(Dictionary<string, string> itemProperties, ItemType itemType)
        {
            
            return false;
        }
    }
}