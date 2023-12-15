using AddressWebApi.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Request.Query.Settlement;

public class GetSettlementByIdQuery : IRequest<SettlementDto>
{
    [Required]
    public int? Id { get; set; }
}
