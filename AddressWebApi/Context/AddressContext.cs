using AddressWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Context;

public class AddressContext : DbContext
{
    public AddressContext(DbContextOptions<AddressContext> options)
    : base(options)
    {
    }

    public virtual DbSet<Region> Regions { get; set; }
}
