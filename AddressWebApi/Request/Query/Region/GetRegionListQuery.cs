using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AddressWebApi.Request.Query.Region;

public class GetRegionListQuery : IRequest<IEnumerable<RegionDto>>
{
}