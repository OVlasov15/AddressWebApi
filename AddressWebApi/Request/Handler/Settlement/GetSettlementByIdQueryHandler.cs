using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.Settlement;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace AddressWebApi.Request.Handler.Settlement;

public class GetSettlementByIdQueryHandler : IRequestHandler<GetSettlementByIdQuery, SettlementDto>
{
    private readonly ISettlementService _settlementService;

    public GetSettlementByIdQueryHandler(ISettlementService settlementService)
    {
        _settlementService = settlementService;
    }

    public async Task<SettlementDto> Handle(GetSettlementByIdQuery request, CancellationToken cancellationToken)
    {
        SettlementDto settlementDto = await _settlementService.GetByIdAsync(request.Id.Value, cancellationToken);

        return settlementDto;
    }
}