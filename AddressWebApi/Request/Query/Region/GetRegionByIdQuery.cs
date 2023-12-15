using AddressWebApi.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.Region;

public class GetRegionByIdQuery : IRequest<RegionDto>
{
    [Required]
    public int? Id { get; set; }
}
