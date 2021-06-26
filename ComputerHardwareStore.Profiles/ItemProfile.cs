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
            CreateMap<Item, ItemReadDto>();
        }
    }
}