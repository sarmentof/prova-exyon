using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MatrizConhecimentoWeb.Models
{
    public partial class MATRIZDBContext : DbContext
    {
        public MATRIZDBContext()
        {
        }

        public MATRIZDBContext(DbContextOptions<MATRIZDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assuntos> Assuntos { get; set; }
        public virtual DbSet<Criterios> Criterios { get; set; }
        public virtual DbSet<NotasUsuariosAssunto> NotasUsuariosAssunto { get; set; }
        public virtual DbSet<TiposAssunto> TiposAssunto { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=MATRIZDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assuntos>(entity =>
            {
                entity.HasKey(e => new { e.idAssunto, e.idTipoAssunto })
                    .HasName("idAssunto");

                entity.Property(e => e.idAssunto).ValueGeneratedOnAdd();

                entity.Property(e => e.nomeAssunto)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.idTipoAssuntoNavigation)
                    .WithMany(p => p.Assuntos)
                    .HasForeignKey(d => d.idTipoAssunto)
                    .HasConstraintName("TipoAssunto_Assunto_fk");
            });

            modelBuilder.Entity<Criterios>(entity =>
            {
                entity.HasKey(e => e.idCriterio)
                    .HasName("idCriterio");

                entity.Property(e => e.nomeCriterio)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NotasUsuariosAssunto>(entity =>
            {
                entity.HasKey(e => new { e.idNotaUsuarioAssunto, e.idAssunto, e.idTipoAssunto, e.idUsuario, e.idCriterio })
                    .HasName("idNotaUsuarioAssunto");

                entity.Property(e => e.idNotaUsuarioAssunto).ValueGeneratedOnAdd();

                entity.HasOne(d => d.idCriterioNavigation)
                    .WithMany(p => p.NotasUsuariosAssunto)
                    .HasForeignKey(d => d.idCriterio)
                    .HasConstraintName("Criterios_NotasUsuarioAssunto_fk");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.NotasUsuariosAssunto)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("Usuarios_NotasUsuarioAssunto_fk");

                entity.HasOne(d => d.id)
                    .WithMany(p => p.NotasUsuariosAssunto)
                    .HasForeignKey(d => new { d.idAssunto, d.idTipoAssunto })
                    .HasConstraintName("Assunto_NotasUsuarioAssunto_fk");
            });

            modelBuilder.Entity<TiposAssunto>(entity =>
            {
                entity.HasKey(e => e.idTipoAssunto)
                    .HasName("idTipoAssunto");

                entity.Property(e => e.nomeTipoAssunto)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.idUsuario)
                    .HasName("idUsuario");

                entity.Property(e => e.cpf)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.dtNascimento).HasColumnType("datetime");

                entity.Property(e => e.login)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.nome)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.senha)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
