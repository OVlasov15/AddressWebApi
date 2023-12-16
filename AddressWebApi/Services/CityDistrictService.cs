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

internal class CityDistrictService : ICityDistrictService
{
    private readonly AddressContext _addressContext;

    public CityDistrictService(AddressContext addressContext)
    {
        _addressContext = addressContext;
    }

    public async Task<CityDistrictDto> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        CityDistrict cityDistrict = await _addressContext.CityDistricts
            .Where(cityDistrict => cityDistrict.Id == id)
            .FirstOrDefaultAsync(cancellationToken);

        CityDistrictDto cityDistrictDto = cityDistrict.ToDto();

        return cityDistrictDto;
    }

    public async Task<IEnumerable<CityDistrictDto>> GetListByCityIdAsync(int cityId, CancellationToken cancellationToken)
    {
        IEnumerable<CityDistrict> cityDistrictList = await _addressContext.CityDistricts
            .Where(cityDistrict => cityDistrict.SettlementId == cityId)
            .ToListAsync(cancellationToken);

        IEnumerable<CityDistrictDto> cityDistrictDtoList = cityDistrictList.ToDto();

        return cityDistrictDtoList;
    }

    public async Task<IEnumerable<CityDistrictDto>> GetListByNameAsync(string name, CancellationToken cancellationToken)
    {
        IEnumerable<CityDistrict> cityDistrictList = await _addressContext.CityDistricts
            .Where(cityDistrict => cityDistrict.Name.Contains(name))
            .ToListAsync(cancellationToken);

        IEnumerable<CityDistrictDto> cityDistrictDtoList = cityDistrictList.ToDto();

        return cityDistrictDtoList;
    }
}
