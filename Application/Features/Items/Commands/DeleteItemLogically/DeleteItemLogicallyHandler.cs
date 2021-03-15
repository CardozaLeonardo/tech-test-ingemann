
using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Items.Commands.DeleteItemLogically
{
    public class DeleteItemLogicallyHandler : IRequestHandler<DeleteItemLogicallyCommand, Response<string>>
    {

        private readonly IItemRepositoryAsync _itemRepository;
        private readonly IMapper _mapper;

        public DeleteItemLogicallyHandler(IItemRepositoryAsync itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(DeleteItemLogicallyCommand request, CancellationToken cancellationToken)
        {
            var item = await _itemRepository.GetByIdAsync(request.Id);
            if (item == null)
            {
                throw new NotFoundException("The item was not found!");
            }

            item.Active = false;
            await _itemRepository.UpdateAsync(item);
            return new Response<string>("Deactivate!");
        }
    }
}
