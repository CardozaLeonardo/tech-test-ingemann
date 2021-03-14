using System.Threading.Tasks;
using Application.Features.Invoices.Commands.SaveInvoice;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class InvoiceController: ApiBaseController
    {
        [HttpPost]
        public async Task<IActionResult> Post(SaveInvoiceCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}