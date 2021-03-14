using System.Collections.Generic;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsQuery: IRequest<Response<ICollection<GetAllItemsViewModel>>>
    {
        
    }
}