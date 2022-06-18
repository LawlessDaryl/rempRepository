using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace remp.Models
{
    public partial class RegEmpleadosDBContext : DbContext
    {
        public RegEmpleadosDBContext()
        {
        }

        public RegEmpleadosDBContext(DbContextOptions<RegEmpleadosDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BonoAntiguedad> BonoAntiguedads { get; set; }
        public virtual DbSet<BonoAntiguedadEmpleado> BonoAntiguedadEmpleados { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<DescuentosSalario> DescuentosSalarios { get; set; }
        public virtual DbSet<DescuentosSalarioEmpleado> DescuentosSalarioEmpleados { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<NivelSalarial> NivelSalarials { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vacacione> Vacaciones { get; set; }
        public virtual DbSet<VacacionesEmpleado> VacacionesEmpleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-2TORCFK;database=RegEmpleadosDB;trusted_connection=true;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BonoAntiguedad>(entity =>
            {
                entity.ToTable("bono_antiguedad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Macimo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("macimo");

                entity.Property(e => e.Minimo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("minimo");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("porcentaje");
            });

            modelBuilder.Entity<BonoAntiguedadEmpleado>(entity =>
            {
                entity.ToTable("bono_antiguedad_empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BonoId).HasColumnName("bono_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Bono)
                    .WithMany(p => p.BonoAntiguedadEmpleados)
                    .HasForeignKey(d => d.BonoId)
                    .HasConstraintName("FK__bono_anti__bono___4316F928");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.BonoAntiguedadEmpleados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__bono_anti__emple__4222D4EF");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("cargo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.NivelSalarialId).HasColumnName("nivel_salarial_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Cargos)
                    .HasForeignKey(d => d.DepartamentoId)
                    .HasConstraintName("FK__cargo__departame__31EC6D26");

                entity.HasOne(d => d.NivelSalarial)
                    .WithMany(p => p.Cargos)
                    .HasForeignKey(d => d.NivelSalarialId)
                    .HasConstraintName("FK__cargo__nivel_sal__32E0915F");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("departamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.NoombreDepartamento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("noombre_departamento");
            });

            modelBuilder.Entity<DescuentosSalario>(entity =>
            {
                entity.ToTable("descuentos_salario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("porcentaje");
            });

            modelBuilder.Entity<DescuentosSalarioEmpleado>(entity =>
            {
                entity.ToTable("descuentos_salario_empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescuentosSalarioId).HasColumnName("descuentos_salario_id");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.HasOne(d => d.DescuentosSalario)
                    .WithMany(p => p.DescuentosSalarioEmpleados)
                    .HasForeignKey(d => d.DescuentosSalarioId)
                    .HasConstraintName("FK__descuento__descu__3F466844");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.DescuentosSalarioEmpleados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__descuento__emple__3E52440B");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CargoId).HasColumnName("cargo_id");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ingreso");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_salida");

                entity.Property(e => e.PersonaId).HasColumnName("persona_id");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CargoId)
                    .HasConstraintName("FK__empleado__cargo___38996AB5");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("FK__empleado__person__37A5467C");
            });

            modelBuilder.Entity<NivelSalarial>(entity =>
            {
                entity.ToTable("nivel_salarial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("monto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__usuario__emplead__3B75D760");
            });

            modelBuilder.Entity<Vacacione>(entity =>
            {
                entity.ToTable("vacaciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CantidadDias).HasColumnName("cantidad_dias");

                entity.Property(e => e.MaximoAnios).HasColumnName("maximo_anios");

                entity.Property(e => e.MinimoAnios).HasColumnName("minimo_anios");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");
            });

            modelBuilder.Entity<VacacionesEmpleado>(entity =>
            {
                entity.ToTable("vacaciones_empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaRegreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_regreso");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_salida");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.VacacionesId).HasColumnName("vacaciones_id");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.VacacionesEmpleados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__vacacione__emple__45F365D3");

                entity.HasOne(d => d.Vacaciones)
                    .WithMany(p => p.VacacionesEmpleados)
                    .HasForeignKey(d => d.VacacionesId)
                    .HasConstraintName("FK__vacacione__vacac__46E78A0C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
