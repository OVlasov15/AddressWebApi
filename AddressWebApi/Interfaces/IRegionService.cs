using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using AddressWebApi.Models;

namespace AddressWebApi.Interfaces;

public interface IRegionService
{
    Task<IEnumerable<RegionDto>> GetListAsync(CancellationToken cancellationToken);
    Task<IEnumerable<RegionDto>> GetListByNameAsync(string name, CancellationToken cancellationToken);
    Task<RegionDto> GetByIdAsync(int id, CancellationToken cancellationToken);
}