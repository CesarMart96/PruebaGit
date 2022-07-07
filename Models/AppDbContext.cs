using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TheCapitalBurguer.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("data source= LAPTOP-96DRR7OA;initial catalog= TheCapitalBurguer;user id=sa;password=Topostroy3r");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Apellidos).IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK__Pedido__75E3EFCE4CEFE7FF");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Dirección)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Productos).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
