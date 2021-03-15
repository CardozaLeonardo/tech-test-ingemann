using System.ComponentModel.DataAnnotations;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Items.Commands.SaveItem
{
    public class SaveItemCommand: IRequest<Response<int>>
    {
        [Required]
        public string Code { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public float Price { get; set; }
        
        [Required]
        public float Cost { get; set; }
    }
}