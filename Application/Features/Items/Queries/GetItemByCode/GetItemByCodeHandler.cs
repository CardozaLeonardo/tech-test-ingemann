using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Features.Items.Queries.GetAllItems;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Items.Queries.GetItemByCode
{
    public class GetItemByCodeHandler: IRequestHandler<GetItemByCodeQuery, Response<GetAllItemsViewModel>>
    {
        private readonly IItemRepositoryAsync _itemRepository;
        private readonly IMapper _mapper;

        public GetItemByCodeHandler(IItemRepositoryAsync itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        public async Task<Response<GetAllItemsViewModel>> Handle(GetItemByCodeQuery request, CancellationToken cancellationToken)
        {
            var item = await _itemRepository.GetByCode(request.Code);

            if (item == null)
            {
                throw new NotFoundException("The item was not found!");
            }

            var itemsViewModel = _mapper.Map<GetAllItemsViewModel>(item);

            return new Response<GetAllItemsViewModel>(itemsViewModel);
        }
    }
}