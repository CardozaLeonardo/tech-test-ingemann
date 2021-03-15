using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsHandler: IRequestHandler<GetAllItemsQuery, Response<ICollection<GetAllItemsViewModel>>>
    {
        private readonly IItemRepositoryAsync _itemRepository;
        private readonly IMapper _mapper;

        public GetAllItemsHandler(IItemRepositoryAsync itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        public async Task<Response<ICollection<GetAllItemsViewModel>>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var itemModels = await _itemRepository.GetAllActiveAsync();
            var items = _mapper.Map<ICollection<GetAllItemsViewModel>>(itemModels);

            return new Response<ICollection<GetAllItemsViewModel>>(items);
        }
    }
}