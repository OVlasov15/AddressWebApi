using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AddressWebApi.Request.Query.RegionDistrict;

public class GetRegionDistrictListByNameQuery : IRequest<IEnumerable<RegionDistrictDto>>
{
    public string Name {  get; set; }
}
