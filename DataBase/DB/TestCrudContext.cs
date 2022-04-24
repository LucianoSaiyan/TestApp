using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataBase.DB
{
    public partial class TestCrudContext : DbContext
    {
        public TestCrudContext()
        {
        }

        public TestCrudContext(DbContextOptions<TestCrudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TGenero> TGeneros { get; set; }
        public virtual DbSet<TPelicula> TPeliculas { get; set; }
        public virtual DbSet<TRol> TRols { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LUCHO-PC\\ADMIN;Database=TestCrud;Persist Security Info=False;User ID=sa;Pwd=12345;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TGenero>(entity =>
            {
                entity.HasKey(e => e.CodGenero)
                    .HasName("PK__tGenero__0DACB9D5E1556085");

                entity.ToTable("tGenero");

                entity.Property(e => e.CodGenero).HasColumnName("cod_genero");

                entity.Property(e => e.TxtDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("txt_desc");
            });

            modelBuilder.Entity<TPelicula>(entity =>
            {
                entity.HasKey(e => e.CodPelicula)
                    .HasName("PK__tPelicul__225F6E0820B1EA12");

                entity.ToTable("tPelicula");

                entity.Property(e => e.CodPelicula).HasColumnName("cod_pelicula");

                entity.Property(e => e.CantDisponiblesAlquiler).HasColumnName("cant_disponibles_alquiler");

                entity.Property(e => e.CantDisponiblesVenta).HasColumnName("cant_disponibles_venta");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.PrecioAlquiler)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("precio_alquiler");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("precio_venta");

                entity.Property(e => e.TxtDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("txt_desc");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.TPeliculas)
                    .HasForeignKey(d => d.IdGenero)
                    .HasConstraintName("FK__tPelicula__idGen__34C8D9D1");
            });

            modelBuilder.Entity<TRol>(entity =>
            {
                entity.HasKey(e => e.CodRol)
                    .HasName("PK__tRol__F13B121189DD342D");

                entity.ToTable("tRol");

                entity.Property(e => e.CodRol).HasColumnName("cod_rol");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("txt_desc");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.CodUsuario)
                    .HasName("PK__tUsers__EA3C9B1A51133BCD");

                entity.ToTable("tUsers");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodRol).HasColumnName("cod_rol");

                entity.Property(e => e.NroDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nro_doc");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("txt_apellido");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("txt_nombre");

                entity.Property(e => e.TxtPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("txt_password");

                entity.Property(e => e.TxtUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("txt_user");

                entity.HasOne(d => d.CodRolNavigation)
                    .WithMany(p => p.TUsers)
                    .HasForeignKey(d => d.CodRol)
                    .HasConstraintName("fk_user_rol");
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.Property(e => e.IdTipoUsuario).ValueGeneratedNever();

                entity.Property(e => e.DescripcionTipo).HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK_Usuarios_TiposUsuarios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
