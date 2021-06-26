using System;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.DB
{
    public class ItemRepositoryTest : IItemRepository
    {
        public bool SaveChangesFunc()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAllItems()
        {
            var items = new List<Item>
            {
                new Item
                {
                    Id = new Guid(),
                    Name = "GTX 3080",
                    Vendor = "nVidia",
                    Type = "videocard",
                    Quantity = 10,
                    ShortDescription = "a videocard for PC",
                    Description = "a powerfull videocard for PC",
                    Price = 1000
                },
                new Item
                {
                    Id = new Guid(),
                    Name = "GTX 3080Ti",
                    Vendor = "nVidia",
                    Type = "videocard",
                    Quantity = 10,
                    ShortDescription = "a videocard for PC",
                    Description = "a powerfull videocard for PC",
                    Price = 1500
                },
                new Item
                {
                    Id = new Guid(),
                    Name = "ASUS G5T6",
                    Vendor = "ASUS",
                    Type = "motherboard",
                    Quantity = 0,
                    ShortDescription = "a motherboard for PC",
                    Description = "a motherboard for PC",
                    Price = 1500
                }
            };
            return items;
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

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}