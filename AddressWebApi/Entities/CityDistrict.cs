using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Entities;

public class CityDistrict
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Name { get; set; }

    [ForeignKey(nameof(Settlement))]
    public int SettlementId { get; set; }

    public Settlement Settlement { get; set; }
}
