using Application.Wrappers;
using MediatR;

namespace Application.Features.Items.Commands.UpdateItem
{
    public class UpdateItemCommand: IRequest<Response<string>>
    {
        public int Key { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
    }
}
