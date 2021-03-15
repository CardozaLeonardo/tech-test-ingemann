using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Items.Commands.UpdateItem
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, Response<string>>
    {
        private readonly IItemRepositoryAsync _itemRepository;
        private readonly IMapper _mapper;

        public UpdateItemHandler(IItemRepositoryAsync itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        
        public async Task<Response<string>> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _itemRepository.GetByIdAsync(request.Key);
            if(item == null)
            {
                throw new NotFoundException("The item was not found!");
            }

            //var codeAlreadyUsed = await _itemRepository

            _mapper.Map(request, item);

            await _itemRepository.UpdateAsync(item);
            return new Response<string>("Updated!");
        }
    }
}
