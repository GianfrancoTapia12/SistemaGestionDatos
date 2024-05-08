using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.AccesoDatos.Repositorio.IRepositorio
{
    public interface IEmpresaRepositorio : IRepositorio<Empresa>
    {

        void Actualizar(Empresa empresa);
    }
}
