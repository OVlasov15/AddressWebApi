using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.RegionDistrict;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace AddressWebApi.Request.Handler.RegionDistrict;

public class GetRegionDistrictByIdQueryHandler : IRequestHandler<GetRegionDistrictByIdQuery, RegionDistrictDto>
{
    private readonly IRegionDistrictService _regionDistrictService;

    public GetRegionDistrictByIdQueryHandler(IRegionDistrictService regionDistrictService)
    {
        _regionDistrictService = regionDistrictService;
    }

    public async Task<RegionDistrictDto> Handle(GetRegionDistrictByIdQuery request, CancellationToken cancellationToken)
    {
        RegionDistrictDto regionDistrictDto = await _regionDistrictService.GetByIdAsync(request.Id.Value, cancellationToken);

        return regionDistrictDto;
    }
}
