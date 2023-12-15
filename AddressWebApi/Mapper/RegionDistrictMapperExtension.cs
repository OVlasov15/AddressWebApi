using AddressWebApi.Entities;
using AddressWebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace AddressWebApi.Mapper;

internal static class RegionDistrictMapperExtension
{
    public static IEnumerable<RegionDistrictDto> ToDto(this IEnumerable<RegionDistrict> regionDistrictList)
    {
        if (regionDistrictList.IsNullOrEmpty())
        {
            return Enumerable.Empty<RegionDistrictDto>();
        }

        IEnumerable<RegionDistrictDto> regionDtoList = regionDistrictList.Select(region => region.ToDto());

        return regionDtoList;
    }

    public static RegionDistrictDto ToDto(this RegionDistrict regionDistrict)
    {
        if (regionDistrict is null)
        {
            return null;
        }

        var regionDistrictDto = new RegionDistrictDto
        {
            Id = regionDistrict.Id,
            Name = regionDistrict.Name,
            RegionId = regionDistrict.RegionId
        };

        return regionDistrictDto;
    }
}
