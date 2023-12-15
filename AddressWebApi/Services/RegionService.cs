using AddressWebApi.Context;
using AddressWebApi.Entities;
using AddressWebApi.Interfaces;
using AddressWebApi.Mapper;
using AddressWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

    public async Task<IEnumerable<RegionDto>> GetListAsync(CancellationToken cancellationToken)
    {
        IEnumerable<Region> regionList = await _addressContext.Regions.ToListAsync(cancellationToken);

        IEnumerable<RegionDto> regionDtoList = regionList.ToDto();

        return regionDtoList;
    }
}
