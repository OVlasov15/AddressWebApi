using AddressWebApi.Enums;

namespace AddressWebApi.Models;

public class SettlementDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public SettlementType Type { get; set; }
    public int? RegionDistrictId { get; set; }
}
