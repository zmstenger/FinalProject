using Microsoft.EntityFrameworkCore;
namespace FinalProject.Models;


public class EquipmentContext : DbContext
{
    public EquipmentContext(DbContextOptions<EquipmentContext> options)
        : base(options)
    {
    }

    public DbSet<Equipment> MyEquipment { get; set; }
}
