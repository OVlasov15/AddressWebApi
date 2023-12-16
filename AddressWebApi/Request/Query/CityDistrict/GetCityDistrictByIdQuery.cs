using AddressWebApi.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.CityDistrict;

public class GetCityDistrictByIdQuery : IRequest<CityDistrictDto>
{
    [Required]
    public int? Id { get; set; }
}
