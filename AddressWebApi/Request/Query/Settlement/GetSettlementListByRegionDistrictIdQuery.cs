using AddressWebApi.Enums;
using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.Settlement;

public class GetSettlementListByRegionDistrictIdQuery : IRequest<IEnumerable<SettlementDto>>
{
    public SettlementType[] Type { get; set; }

    [Required]
    public int? RegionDistrictId { get; set; }
}