using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.Region;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace AddressWebApi.Request.Handler.Region;

public class GetRegionListQueryHandler : IRequestHandler<GetRegionListQuery, IEnumerable<RegionDto>>
{
    private readonly IRegionService _regionService;

    public GetRegionListQueryHandler(IRegionService regionService)
    {
        _regionService = regionService;
    }

    public async Task<IEnumerable<RegionDto>> Handle(GetRegionListQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<RegionDto> brendDto = await _regionService.GetListAsync(cancellationToken);

        return brendDto;
    }
}