using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AddressWebApi.Enums;

namespace AddressWebApi.Entities;

public class Settlement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Name { get; set; }

    public SettlementType Type { get; set; }

    [ForeignKey(nameof(RegionDistrict))]
    public int? RegionDistrictId { get; set; }


    public RegionDistrict RegionDistrict { get; set; }
}