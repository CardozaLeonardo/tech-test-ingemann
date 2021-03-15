using System.Threading.Tasks;
using Application.Features.Items.Commands.DeleteItemLogically;
using Application.Features.Items.Commands.SaveItem;
using Application.Features.Items.Commands.UpdateItem;
using Application.Features.Items.Queries.GetAllItems;
using Application.Features.Items.Queries.GetItemByCode;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class ItemController: ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllItemsQuery()));
        }
        
        [HttpGet("{term}")]
        public async Task<IActionResult> Get(string term)
        {
            return Ok(await Mediator.Send(new GetItemByCodeQuery() {Code = term}));
        }

        [HttpPost]
        public async Task<IActionResult> Post(SaveItemCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put (int id, UpdateItemCommand command)
        {
            command.Key = id;
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteItemLogicallyCommand() { Id = id }));
        }

    }
}