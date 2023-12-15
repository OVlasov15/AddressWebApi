using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.RegionDistrict;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace AddressWebApi.Request.Handler.RegionDistrict;

public class GetRegionDistrictListByRegionIdQueryHandler : IRequestHandler<GetRegionDistrictListByRegionIdQuery, IEnumerable<RegionDistrictDto>>
{
    private readonly IRegionDistrictService _regionDistrictService;

    public GetRegionDistrictListByRegionIdQueryHandler(IRegionDistrictService regionDistrictService)
    {
        _regionDistrictService = regionDistrictService;
    }

    public async Task<IEnumerable<RegionDistrictDto>> Handle(GetRegionDistrictListByRegionIdQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<RegionDistrictDto> regionDistrictDto = await _regionDistrictService.GetListByRegionIdAsync(request.RegionId.Value, cancellationToken);

        return regionDistrictDto;
    }
}
