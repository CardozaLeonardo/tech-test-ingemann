using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Invoices.Commands.SaveInvoice
{
    public class SaveInvoiceHandler: IRequestHandler<SaveInvoiceCommand, Response<int>>
    {
        private readonly IInvoiceRepositoryAsync _invoiceRepository;
        private readonly IMapper _mapper;

        public SaveInvoiceHandler(IInvoiceRepositoryAsync invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }
        public async Task<Response<int>> Handle(SaveInvoiceCommand request, CancellationToken cancellationToken)
        {
            var invoiceDetailModels = _mapper.Map<ICollection<InvoiceDetail>>(request.InvoiceDetails);
            var newInvoice = new Invoice
            {
                Date = DateTime.Now, Tax = (float) 0.15, InvoiceDetails = invoiceDetailModels
            };

            await _invoiceRepository.AddAsync(newInvoice);
            return new Response<int>(newInvoice.Id);
        }
    }
}