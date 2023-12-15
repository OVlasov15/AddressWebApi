using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.RegionDistrict;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace AddressWebApi.Request.Handler.RegionDistrict;

public class GetRegionDistrictListByNameQueryHandler : IRequestHandler<GetRegionDistrictListByNameQuery, IEnumerable<RegionDistrictDto>>
{
    private readonly IRegionDistrictService _regionDistrictService;

    public GetRegionDistrictListByNameQueryHandler(IRegionDistrictService regionDistrictService)
    {
        _regionDistrictService = regionDistrictService;
    }

    public async Task<IEnumerable<RegionDistrictDto>> Handle(GetRegionDistrictListByNameQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<RegionDistrictDto> regionDistrictDtoList = await _regionDistrictService.GetListByNameAsync(request.Name, cancellationToken);

        return regionDistrictDtoList;
    }
}
