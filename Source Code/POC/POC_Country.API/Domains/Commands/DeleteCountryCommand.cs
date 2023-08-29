using MediatR;

namespace POC_Country.API.Domains.Commands
{
    public class DeleteCountryCommand: IRequest<short>
    {
        public short CountryId { get; set; }
    }
}
