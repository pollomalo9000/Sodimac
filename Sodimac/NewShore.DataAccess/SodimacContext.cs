using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NewShore.DataAccess;

public partial class SodimacContext : DbContext
{
    public SodimacContext()
    {
    }

    public SodimacContext(DbContextOptions<SodimacContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblInvCoDespachadasN> TblInvCoDespachadasNs { get; set; }

    public virtual DbSet<TblInvNpComprometidasN> TblInvNpComprometidasNs { get; set; }

    public virtual DbSet<TblInvUbicacionesN> TblInvUbicacionesNs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HQIUKCO\\OSCARBD;Database=Sodimac;User Id=sa;Password=123456789;Encrypt=False; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblInvCoDespachadasN>(entity =>
        {
            entity.HasKey(e => e.IdCoDespachadas).HasName("INV_CO_DESPACHADAS_PK");

            entity.ToTable("TBL_INV_CO_DESPACHADAS_N");

            entity.Property(e => e.IdCoDespachadas)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id_co_despachadas");
            entity.Property(e => e.CoDesp)
                .HasColumnType("numeric(16, 4)")
                .HasColumnName("co_desp");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("date")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("item_name");
            entity.Property(e => e.Number1)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("number_1");
            entity.Property(e => e.Number2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("number_2");
            entity.Property(e => e.Vchar1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vchar_1");
            entity.Property(e => e.Vchar2)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vchar_2");
            entity.Property(e => e.Whse)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("whse");
        });

        modelBuilder.Entity<TblInvNpComprometidasN>(entity =>
        {
            entity.HasKey(e => e.IdNpComprometidas);

            entity.ToTable("TBL_INV_NP_COMPROMETIDAS_N");

            entity.Property(e => e.IdNpComprometidas)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id_np_comprometidas");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("date")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.IdAlmEnt)
                .HasMaxLength(12)
                .HasColumnName("id_alm_ent");
            entity.Property(e => e.IdEstado)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("id_estado");
            entity.Property(e => e.Number1)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("number_1");
            entity.Property(e => e.Number2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("number_2");
            entity.Property(e => e.OrgLvlChild)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("org_lvl_child");
            entity.Property(e => e.QtyPend)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("qty_pend");
            entity.Property(e => e.SkuId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sku_id");
            entity.Property(e => e.Sticker)
                .HasMaxLength(200)
                .HasColumnName("sticker");
            entity.Property(e => e.Vchar1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vchar_1");
            entity.Property(e => e.Vchar2)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vchar_2");
        });

        modelBuilder.Entity<TblInvUbicacionesN>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion);

            entity.ToTable("TBL_INV_UBICACIONES_N");

            entity.Property(e => e.IdUbicacion)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id_ubicacion");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("date")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.IdItem)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("id_item");
            entity.Property(e => e.Number1)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("number_1");
            entity.Property(e => e.Number2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("number_2");
            entity.Property(e => e.OnHandQty)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("on_hand_qty");
            entity.Property(e => e.PrdLvlChild)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prd_lvl_child");
            entity.Property(e => e.QtyCantidadNoAlmacenada)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("qtyCantidadNoAlmacenada");
            entity.Property(e => e.QtyReserva)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("qtyReserva");
            entity.Property(e => e.SkuId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sku_id");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ubicacion");
            entity.Property(e => e.Vchar1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vchar_1");
            entity.Property(e => e.Vchar2)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("vchar_2");
            entity.Property(e => e.Whse)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("whse");
            entity.Property(e => e.WmsLocnId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("wms_locn_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
