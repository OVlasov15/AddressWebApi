using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using AddressWebApi.Request.Query.Settlement;

namespace AddressWebApi.Request.Handler.Settlement;

public class GetSettlementListByRegionDistrictIdQueryHandler : IRequestHandler<GetSettlementListByRegionDistrictIdQuery, IEnumerable<SettlementDto>>
{
    private readonly ISettlementService _settlementService;

    public GetSettlementListByRegionDistrictIdQueryHandler(ISettlementService settlementService)
    {
        _settlementService = settlementService;
    }

    public async Task<IEnumerable<SettlementDto>> Handle(GetSettlementListByRegionDistrictIdQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<SettlementDto> settlementDtoList = await _settlementService.GetListByRegionDistrictIdAsync(request.RegionDistrictId.Value, request.Type, cancellationToken);

        return settlementDtoList;
    }
}
