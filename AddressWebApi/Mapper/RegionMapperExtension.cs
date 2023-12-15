using AddressWebApi.Entities;
using AddressWebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace AddressWebApi.Mapper;

internal static class RegionMapperExtension
{
    public static IEnumerable<RegionDto> ToDto(this IEnumerable<Region> regionList)
    {
        if (regionList.IsNullOrEmpty())
        {
            return Enumerable.Empty<RegionDto>();
        }

        IEnumerable<RegionDto> regionDtoList = regionList.Select(region => region.ToDto());

        return regionDtoList;
    }

    public static RegionDto ToDto(this Region region)
    {
        if (region is null)
        {
            return null;
        }

        var regionDto = new RegionDto
        {
            Id = region.Id,
            Name = region.Name,
            AmountRegionDistrict = region.AmountRegionDistrict
        };

        return regionDto;
    }
}