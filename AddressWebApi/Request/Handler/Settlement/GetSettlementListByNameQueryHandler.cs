using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.Settlement;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace AddressWebApi.Request.Handler.Settlement;

public class GetSettlementListByNameQueryHandler : IRequestHandler<GetSettlementListByNameQuery, IEnumerable<SettlementDto>>
{
    private readonly ISettlementService _settlementService;

    public GetSettlementListByNameQueryHandler(ISettlementService settlementService)
    {
        _settlementService = settlementService;
    }

    public async Task<IEnumerable<SettlementDto>> Handle(GetSettlementListByNameQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<SettlementDto>  settlementDtoList = await _settlementService.GetListByNameAsync(request.Name, request.Type, cancellationToken);

        return settlementDtoList;
    }
}
