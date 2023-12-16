using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using AddressWebApi.Request.Query.CityDistrict;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Request.Handler.CityDistrict;

public class GetCityDistrictListByNameQueryHandler : IRequestHandler<GetCityDistrictListByNameQuery, IEnumerable<CityDistrictDto>>
{
    private readonly ICityDistrictService _cityDistrictService;

    public GetCityDistrictListByNameQueryHandler(ICityDistrictService cityDistrictService)
    {
        _cityDistrictService = cityDistrictService;
    }

    public async Task<IEnumerable<CityDistrictDto>> Handle(GetCityDistrictListByNameQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<CityDistrictDto> cityDistrictDtoList = await _cityDistrictService.GetListByNameAsync(request.Name, cancellationToken);

        return cityDistrictDtoList;
    }
}
