using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AddressWebApi.Request.Query.Region;

public class GetRegionListByNameQuery : IRequest<IEnumerable<RegionDto>>
{
    public string Name {  get; set; }
}
