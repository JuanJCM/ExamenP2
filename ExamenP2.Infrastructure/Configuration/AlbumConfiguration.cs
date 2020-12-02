using System;
using System.Collections.Generic;
using System.Text;
using ExamenP2.Core.Entities;
using ExamenP2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenP2.Infrastructure.Configuration
{
    class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Artista).ValueGeneratedOnAdd();
            builder.Property(x => x.Precio).ValueGeneratedOnAdd();
            builder.Property(x => x.Genre).ValueGeneratedOnAdd();
            builder.Property(x => x.Puntuacion).ValueGeneratedOnAdd();
            builder.Property(x => x.Fecha).ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).ValueGeneratedOnAdd();
            builder.Property(x => x.Imagen).ValueGeneratedOnAdd();
            builder.HasMany(x => x.Canciones)
                .WithOne(i => i.Cancion)
                .HasForeignKey(x => x.CancionId);
            
        }
    }
}
