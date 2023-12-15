using AddressWebApi.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using AddressWebApi.Models;

namespace AddressWebApi.Interfaces;

public interface ISettlementService
{
    Task<IEnumerable<SettlementDto>> GetListByRegionDistrictIdAsync(int regionDistrictId, SettlementType[] type, CancellationToken cancellationToken);
    Task<IEnumerable<SettlementDto>> GetListByNameAsync(string name, SettlementType[] type, CancellationToken cancellationToken);
}