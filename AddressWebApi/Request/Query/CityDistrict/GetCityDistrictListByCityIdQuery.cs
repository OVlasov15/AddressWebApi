using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.CityDistrict;

public class GetCityDistrictListByCityIdQuery : IRequest<IEnumerable<CityDistrictDto>>
{
    [Required]
    public int? CityId { get; set; }
}
