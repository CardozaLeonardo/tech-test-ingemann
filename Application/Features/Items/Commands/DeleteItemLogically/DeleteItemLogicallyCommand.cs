using Application.Wrappers;
using MediatR;

namespace Application.Features.Items.Commands.DeleteItemLogically
{
    public class DeleteItemLogicallyCommand: IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
