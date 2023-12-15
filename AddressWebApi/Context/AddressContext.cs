using AddressWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Context;

internal class AddressContext : DbContext
{
    public AddressContext(DbContextOptions<AddressContext> options)
    : base(options)
    {
    }

    public virtual DbSet<Region> Regions { get; set; }
    public virtual DbSet<RegionDistrict> RegionDistricts { get; set; }
    public virtual DbSet<Settlement> Settlements { get; set; }
    public virtual DbSet<CityDistrict> CityDistricts { get; set; }
}
