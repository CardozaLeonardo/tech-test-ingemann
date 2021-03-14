using Application.Features.Items.Queries.GetAllItems;
using Application.Wrappers;
using Domain.Entities;
using MediatR;

namespace Application.Features.Items.Queries.GetItemByCode
{
    public class GetItemByCodeQuery: IRequest<Response<GetAllItemsViewModel>>
    {
        public string Code { get; set; }
    }
}