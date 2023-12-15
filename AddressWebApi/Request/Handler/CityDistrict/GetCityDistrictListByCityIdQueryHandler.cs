using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.CityDistrict;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Request.Handler.CityDistrict;

public class GetCityDistrictListByCityIdQueryHandler : IRequestHandler<GetCityDistrictListByCityIdQuery, IEnumerable<CityDistrictDto>>
{
    private readonly ICityDistrictService _cityDistrictService;

    public GetCityDistrictListByCityIdQueryHandler(ICityDistrictService cityDistrictService)
    {
        _cityDistrictService = cityDistrictService;
    }

    public async Task<IEnumerable<CityDistrictDto>> Handle(GetCityDistrictListByCityIdQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<CityDistrictDto> cityDistrictDtoList = await _cityDistrictService.GetListByCityIdAsync(request.CityId.Value, cancellationToken);

        return cityDistrictDtoList;
    }
}
