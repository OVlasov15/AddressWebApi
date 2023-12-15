using AddressWebApi.Context;
using AddressWebApi.Entities;
using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AddressWebApi.Mapper;

namespace AddressWebApi.Services;

internal class RegionDistrictService : IRegionDistrictService
{
    private readonly AddressContext _addressContext;

    public RegionDistrictService(AddressContext addressContext)
    {
        _addressContext = addressContext;
    }

    public async Task<IEnumerable<RegionDistrictDto>> GetListByRegionIdAsync(int regionId, CancellationToken cancellationToken)
    {
        IEnumerable<RegionDistrict> regionDistrictList = await _addressContext.RegionDistricts
            .Where(regionDistrict => regionDistrict.RegionId == regionId)
            .ToListAsync(cancellationToken);

        IEnumerable<RegionDistrictDto> regionDistrictDtoList = regionDistrictList.ToDto();

        return regionDistrictDtoList;
    }

    public async Task<IEnumerable<RegionDistrictDto>> GetListByNameAsync(string name, CancellationToken cancellationToken)
    {
        IEnumerable<RegionDistrict> regionDistrictList = await _addressContext.RegionDistricts
            .Where(regionDistrict => regionDistrict.Name.Contains(name))
            .ToListAsync(cancellationToken);

        IEnumerable<RegionDistrictDto> regionDistrictDtoList = regionDistrictList.ToDto();

        return regionDistrictDtoList;
    }
}