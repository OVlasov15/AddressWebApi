using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.RegionDistrict;

public class GetRegionDistrictListByRegionIdQuery : IRequest<IEnumerable<RegionDistrictDto>>
{
    [Required]
    public int? RegionId { get; set; }
}
