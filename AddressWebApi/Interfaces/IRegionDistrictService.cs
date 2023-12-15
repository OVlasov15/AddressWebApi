using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using AddressWebApi.Models;

namespace AddressWebApi.Interfaces;

public interface IRegionDistrictService
{
    Task<IEnumerable<RegionDistrictDto>> GetListByRegionIdAsync(int regionId, CancellationToken cancellationToken);

    Task<IEnumerable<RegionDistrictDto>> GetListByNameAsync(string name, CancellationToken cancellationToken);
    Task<RegionDistrictDto> GetByIdAsync(int id, CancellationToken cancellationToken);
}