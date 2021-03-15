using Application.Features.Items.Commands.SaveItem;
using Application.Features.Items.Commands.UpdateItem;
using Application.Features.Items.Queries.GetAllItems;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class ItemProfile: Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, GetAllItemsViewModel>();
            CreateMap<SaveItemCommand, Item>();
            CreateMap<UpdateItemCommand, Item>();
        }
    }
}