using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC.API.DomainLayer.Commands;
using POC.API.DomainLayer.Queries;
using POC.API.Models;

namespace POC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BankController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetBanks")]
        public async Task<List<Bank>> GetBanks()
        {
            var Banks = (List<Bank>)await _mediator.Send(new GetAllBanksQuery());
            return Banks;
        }

        [HttpGet("GetBankById")]
        public async Task<Bank> GetBankById(int bankId)
        {
            var Bank = await _mediator.Send(new GetBankByIdQuery() { BankId = bankId });
            return Bank;
        }

        [HttpPost("AddBank")]
        public async Task<Bank> AddBank(Bank bank)
        {
            var result = await _mediator.Send(new CreateBankCommand(bank));
            return result;
        }

        [HttpPut("UpdateBank")]
        public async Task<int> UpdateBank(Bank bank)
        {
            var result = await _mediator.Send(new UpdateBankCommand(bank));
            return result;
        }

        [HttpDelete("DeleteBank")]
        public async Task<int> DeleteBank(int bankId)
        {
            return await _mediator.Send(new DeleteBankCommand() { BankId = bankId });
        }
    }
}
