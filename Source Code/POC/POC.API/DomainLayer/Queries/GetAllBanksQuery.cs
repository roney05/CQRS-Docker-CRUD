using MediatR;
using POC.API.Models;

namespace POC.API.DomainLayer.Queries
{
    public class GetAllBanksQuery : IRequest<IEnumerable<Bank>>
    {
    }
}
