using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionTienda.Models;

public partial class TiendaContext : DbContext
{
    public TiendaContext()
    {
    }

    public TiendaContext(DbContextOptions<TiendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<Carritocompra> Carritocompras { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Listadedeseo> Listadedeseos { get; set; }

    public virtual DbSet<Metododepago> Metododepagos { get; set; }

    public virtual DbSet<Notificacione> Notificaciones { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=tienda;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.19-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.IdArticulo).HasName("PRIMARY");

            entity.ToTable("articulo");

            entity.Property(e => e.Imagen).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Carritocompra>(entity =>
        {
            entity.HasKey(e => e.IdCarrito).HasName("PRIMARY");

            entity.ToTable("carritocompra");

            entity.HasIndex(e => e.IdArticulo, "Id_Articulo");

            entity.HasIndex(e => e.IdUsuario, "Id_Usuario");

            entity.Property(e => e.IdArticulo).HasColumnName("Id_Articulo");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.Carritocompras)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("carritocompra_ibfk_2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Carritocompras)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("carritocompra_ibfk_1");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.IdCompra).HasName("PRIMARY");

            entity.ToTable("compra");

            entity.HasIndex(e => e.IdCarritoCompra, "Id_CarritoCompra");

            entity.HasIndex(e => e.IdMetodoPago, "Id_MetodoPago");

            entity.Property(e => e.IdCarritoCompra).HasColumnName("Id_CarritoCompra");
            entity.Property(e => e.IdMetodoPago).HasColumnName("Id_MetodoPago");

            entity.HasOne(d => d.IdCarritoCompraNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdCarritoCompra)
                .HasConstraintName("compra_ibfk_1");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdMetodoPago)
                .HasConstraintName("compra_ibfk_2");
        });

        modelBuilder.Entity<Listadedeseo>(entity =>
        {
            entity.HasKey(e => e.IdLista).HasName("PRIMARY");

            entity.ToTable("listadedeseos");

            entity.HasIndex(e => e.IdArticulo, "Id_Articulo");

            entity.HasIndex(e => e.IdUsuario, "Id_Usuario");

            entity.Property(e => e.IdArticulo).HasColumnName("Id_Articulo");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.Listadedeseos)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("listadedeseos_ibfk_2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Listadedeseos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("listadedeseos_ibfk_1");
        });

        modelBuilder.Entity<Metododepago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoDePago).HasName("PRIMARY");

            entity.ToTable("metododepago");

            entity.Property(e => e.Metodo).HasMaxLength(50);
        });

        modelBuilder.Entity<Notificacione>(entity =>
        {
            entity.HasKey(e => e.IdNotificacion).HasName("PRIMARY");

            entity.ToTable("notificaciones");

            entity.HasIndex(e => e.IdArticulo, "Id_Articulo");

            entity.HasIndex(e => e.IdUsuario, "Id_usuario");

            entity.Property(e => e.IdArticulo).HasColumnName("Id_Articulo");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("notificaciones_ibfk_2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("notificaciones_ibfk_1");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.Property(e => e.Apellidos).HasMaxLength(50);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
