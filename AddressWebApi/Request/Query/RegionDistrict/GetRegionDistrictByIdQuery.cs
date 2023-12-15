using AddressWebApi.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.RegionDistrict;

public class GetRegionDistrictByIdQuery : IRequest<RegionDistrictDto>
{
    [Required]
    public int? Id {  get; set; }
}
