using System;
using AutoMapper;
using ComputerHardwareStore.Domain;
using ComputerHardwareStore.Dto;

namespace ComputerHardwareStore.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            //Source -> Destination
            CreateMap<Item, ItemReadDto>();
            //CreateMap<ItemCreateDto, Item>();
        }
    }
}