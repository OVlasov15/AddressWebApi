using AddressWebApi.Context;
using AddressWebApi.Entities;
using AddressWebApi.Enums;
using AddressWebApi.Interfaces;
using AddressWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using AddressWebApi.Mapper;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Services;

internal class SettlementService : ISettlementService
{
    private readonly AddressContext _addressContext;
    private SettlementType[] _allSettlementType =
    [
        SettlementType.City,
        SettlementType.Towns,
        SettlementType.Village
    ];

    public SettlementService(AddressContext addressContext)
    {
        _addressContext = addressContext;
    }

    public async Task<IEnumerable<SettlementDto>> GetListByNameAsync(string name, SettlementType[] type, CancellationToken cancellationToken)
    {
        if (type is null)
        {
            type = _allSettlementType;
        }

        IEnumerable<Settlement> settlementList = await _addressContext.Settlements
            .Where(settlement => type.Contains(settlement.Type) && settlement.Name.Contains(name))
            .ToListAsync(cancellationToken);

        IEnumerable<SettlementDto> settlementDtoList = settlementList.ToDto();

        return settlementDtoList;
    }

    public async Task<IEnumerable<SettlementDto>> GetListByRegionDistrictIdAsync(int regionDistrictId, SettlementType[] type, CancellationToken cancellationToken)
    {
        if (type is null)
        {
            type = _allSettlementType;
        }

        IEnumerable<Settlement> settlementList = await _addressContext.Settlements
            .Where(settlement => type.Contains(settlement.Type) && settlement.RegionDistrictId == regionDistrictId)
            .ToListAsync(cancellationToken);

        IEnumerable<SettlementDto> settlementDtoList = settlementList.ToDto();

        return settlementDtoList;
    }
}