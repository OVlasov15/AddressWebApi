using AddressWebApi.Enums;
using AddressWebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AddressWebApi.Request.Query.Settlement;

public class GetSettlementListByNameQuery : IRequest<IEnumerable<SettlementDto>>
{
    public SettlementType[] Type { get; set; }
    public string Name { get; set; }
}
