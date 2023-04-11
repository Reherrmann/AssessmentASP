﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace amigos.DATA.Models
{
    public partial class LocalDBMSSQLLocalDBContext : DbContext
    {
        public LocalDBMSSQLLocalDBContext()
        {
        }

        public LocalDBMSSQLLocalDBContext(DbContextOptions<LocalDBMSSQLLocalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Amigo> Amigo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amigo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmigoLastN)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AmigoName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.EstadoId).ValueGeneratedNever();

                entity.Property(e => e.EstadoName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.EstadoId)
                    .HasName("PK__Estados__FEF86B00D10DB214");

                entity.Property(e => e.EstadoId).ValueGeneratedNever();

                entity.Property(e => e.EstadoName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.PaisId).ValueGeneratedNever();

                entity.Property(e => e.PaisFlag).HasColumnType("image");

                entity.Property(e => e.PaisImagem)
                    .HasMaxLength(10)
                    .HasColumnName("Pais.Imagem")
                    .IsFixedLength();

                entity.Property(e => e.PaisName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}