using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Items.Commands.SaveItem
{
    public class SaveItemHandler: IRequestHandler<SaveItemCommand, Response<int>>
    {
        private readonly IItemRepositoryAsync _itemRepository;
        private readonly IMapper _mapper;

        public SaveItemHandler(IItemRepositoryAsync itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        
        public async Task<Response<int>> Handle(SaveItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _itemRepository.GetByCode(request.Code);

            if (item != null)
            {
                throw new ConflictException("This code is already registered!");
            }

            var itemModel = _mapper.Map<Item>(request);
            await _itemRepository.AddAsync(itemModel);

            return new Response<int>(itemModel.Id);
        }
    }
}