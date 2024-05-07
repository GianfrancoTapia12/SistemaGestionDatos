using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.AccesoDatos.Configuracion
{
    public class EmpresaConfiguracion : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x =>x.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(x =>x.Ruc).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Telefono).IsRequired();
            builder.Property(x => x.Actividad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.NEmpleados).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
        }
    }
}
