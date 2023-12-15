using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Entities;

public class RegionDistrict
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Name { get; set; }

    [ForeignKey("Region")]
    public int RegionId { get; set; }


    public Region Region { get; set; }
}
