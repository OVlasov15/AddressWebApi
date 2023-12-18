using AddressWebApi.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressWebApi.Entities;

public class Street
{
    public int Id { get; set; }
    public string Name { get; set; }
    public StreetType Type { get; set; }

    [ForeignKey(nameof(Settlement))]
    public int SettlementId { get; set; }

    [ForeignKey(nameof(CityDistrict))]
    public int? CityDistrictId { get; set; }


    public Settlement Settlement { get; set; }
    public CityDistrict CityDistrict { get; set; }
}