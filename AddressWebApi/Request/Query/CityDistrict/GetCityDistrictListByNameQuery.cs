using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AddressWebApi.Request.Query.CityDistrict;

public class GetCityDistrictListByNameQuery : IRequest<IEnumerable<CityDistrictDto>>
{
    public string Name { get; set; }
}
