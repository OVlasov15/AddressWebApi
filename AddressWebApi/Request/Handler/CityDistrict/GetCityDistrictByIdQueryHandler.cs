using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.CityDistrict;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Request.Handler.CityDistrict;

public class GetCityDistrictByIdQueryHandler : IRequestHandler<GetCityDistrictByIdQuery, CityDistrictDto>
{
    private readonly ICityDistrictService _cityDistrictService;

    public GetCityDistrictByIdQueryHandler(ICityDistrictService cityDistrictService)
    {
        _cityDistrictService = cityDistrictService;
    }

    public async Task<CityDistrictDto> Handle(GetCityDistrictByIdQuery request, CancellationToken cancellationToken)
    {
        CityDistrictDto cityDistrictDto = await _cityDistrictService.GetByIdAsync(request.Id.Value, cancellationToken);

        return cityDistrictDto;
    }
}
