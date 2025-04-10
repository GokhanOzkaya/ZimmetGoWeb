using Microsoft.EntityFrameworkCore;
using ZimmetGo.Models; // Model sınıflarının bulunduğu namespace

namespace ZimmetGo.Data
{
  

    public class ZimmetDbContext : DbContext
    {
        public ZimmetDbContext(DbContextOptions<ZimmetDbContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BakimKaydi>()
                .HasKey(b => b.BakimID);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BakimKaydi>()
                .HasKey(b => b.BakimID);

            modelBuilder.Entity<DemirbasDemirbasTuru>()
                .HasKey(x => new { x.DemirbasID, x.DemirbasTuruID });
            modelBuilder.Entity<DemirbasDurumGecmisi>()
                .HasKey(d => d.DurumGecmisiID);

        }
        
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Lokasyon> Lokasyonlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Demirbas> Demirbaslar { get; set; }
        public DbSet<Zimmet> Zimmetler { get; set; }
        public DbSet<BakimKaydi> BakimKayitlari { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<DemirbasTuru> DemirbasTurleri { get; set; }
        public DbSet<DemirbasDemirbasTuru> DemirbasDemirbasTurleri { get; set; }
        public DbSet<Log> Loglar { get; set; }
        public DbSet<DemirbasDurumGecmisi> DemirbasDurumGecmisleri { get; set; }
        public DbSet<Resim> Resimler { get; set; }
    }
    
}