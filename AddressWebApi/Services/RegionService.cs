using AddressWebApi.Context;
using AddressWebApi.Entities;
using AddressWebApi.Interfaces;
using AddressWebApi.Mapper;
using AddressWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Services;

internal class RegionService : IRegionService
{
    private readonly AddressContext _addressContext;

    public RegionService(AddressContext addressContext)
    {
        _addressContext = addressContext;
    }

    public async Task<RegionDto> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        Region region = await _addressContext.Regions
            .Where(region => region.Id == id)
            .FirstOrDefaultAsync(cancellationToken);

        RegionDto regionDto = region.ToDto();

        return regionDto;
    }

    public async Task<IEnumerable<RegionDto>> GetListAsync(CancellationToken cancellationToken)
    {
        IEnumerable<Region> regionList = await _addressContext.Regions.ToListAsync(cancellationToken);

        IEnumerable<RegionDto> regionDtoList = regionList.ToDto();

        return regionDtoList;
    }

    public async Task<IEnumerable<RegionDto>> GetListByNameAsync(string name, CancellationToken cancellationToken)
    {
        IEnumerable<Region> regionList = await _addressContext.Regions
            .Where(region => region.Name.Contains(name))
            .ToListAsync(cancellationToken);

        IEnumerable<RegionDto> regionDtoList = regionList.ToDto();

        return regionDtoList;
    }
}
