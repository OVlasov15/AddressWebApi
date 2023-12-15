using AddressWebApi.Entities;
using AddressWebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace AddressWebApi.Mapper;

internal static class SettlementMapperExtension
{
    public static IEnumerable<SettlementDto> ToDto(this IEnumerable<Settlement> settlementList)
    {
        if (settlementList.IsNullOrEmpty())
        {
            return Enumerable.Empty<SettlementDto>();
        }

        IEnumerable<SettlementDto> regionDtoList = settlementList.Select(settlement => settlement.ToDto());

        return regionDtoList;
    }

    public static SettlementDto ToDto(this Settlement settlement)
    {
        if (settlement is null)
        {
            return null;
        }

        var settlementDto = new SettlementDto
        {
            Id = settlement.Id,
            Name = settlement.Name,
            Type = settlement.Type,
            RegionDistrictId = settlement.RegionDistrictId
        };

        return settlementDto;
    }
}