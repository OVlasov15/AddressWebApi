using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using AddressWebApi.Models;

namespace AddressWebApi.Interfaces;

public interface IRegionService
{
    Task<IEnumerable<RegionDto>> GetListAsync(CancellationToken cancellationToken);
}