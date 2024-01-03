using BOL;
using Microsoft.EntityFrameworkCore;

namespace DAL;
public class CollectionContext:DbContext{

    public DbSet<Product> Products {get;set;}

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=192.168.10.150;port=3306;user=dac58; password=welcome;database=dac58";       
        optionsBuilder.UseMySQL(conString);
    }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Set Mapping of Table with POCO
        //Relational        instance: Table
        //Object Oriented   instance: POCO Classs
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity => 
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired();
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.Price).IsRequired();
        });
        modelBuilder.Entity<Product>().ToTable("productsData1");
    }
}
