using AddressWebApi.Entities;
using AddressWebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace AddressWebApi.Mapper;

internal static class CityDistrictMapperExtension
{
    public static IEnumerable<CityDistrictDto> ToDto(this IEnumerable<CityDistrict> cityDistrictList)
    {
        if (cityDistrictList.IsNullOrEmpty())
        {
            return Enumerable.Empty<CityDistrictDto>();
        }

        IEnumerable<CityDistrictDto> cityDistrictDtoList = cityDistrictList.Select(cityDistrict => cityDistrict.ToDto());

        return cityDistrictDtoList;
    }

    public static CityDistrictDto ToDto(this CityDistrict cityDistrict)
    {
        if (cityDistrict is null)
        {
            return null;
        }

        var cityDistrictDto = new CityDistrictDto
        {
            Id = cityDistrict.Id,
            Name = cityDistrict.Name,
            CityId = cityDistrict.SettlementId
        };

        return cityDistrictDto;
    }
}
