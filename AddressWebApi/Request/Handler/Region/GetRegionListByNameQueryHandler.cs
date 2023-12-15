using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.Region;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Request.Handler.Region;

public class GetRegionListByNameQueryHandler : IRequestHandler<GetRegionListByNameQuery, IEnumerable<RegionDto>>
{
    private readonly IRegionService _regionService;

    public GetRegionListByNameQueryHandler(IRegionService regionService)
    {
        _regionService = regionService;
    }

    public async Task<IEnumerable<RegionDto>> Handle(GetRegionListByNameQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<RegionDto> regionDto = await _regionService.GetListByNameAsync(request.Name, cancellationToken);

        return regionDto;
    }
}
