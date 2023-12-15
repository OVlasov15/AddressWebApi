using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.Region;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Request.Handler.Region;

public class GetRegionByIdQueryHandler : IRequestHandler<GetRegionByIdQuery, RegionDto>
{
    private readonly IRegionService _regionService;

    public GetRegionByIdQueryHandler(IRegionService regionService)
    {
        _regionService = regionService;
    }

    public async Task<RegionDto> Handle(GetRegionByIdQuery request, CancellationToken cancellationToken)
    {
        RegionDto regionDto = await _regionService.GetByIdAsync(request.Id.Value, cancellationToken);

        return regionDto;
    }
}
