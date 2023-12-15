using AddressWebApi.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AddressWebApi.Interfaces
{
    public interface ICityDistrictService
    {
        Task<IEnumerable<CityDistrictDto>> GetListByCityIdAsync(int cityId, CancellationToken cancellationToken);
    }
}
