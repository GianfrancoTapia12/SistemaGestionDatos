using SistemaGestion.AccesoDatos.Data;
using SistemaGestion.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {

        private readonly ApplicationDbContext _db;
        public IEmpresaRepositorio Empresa {  get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Empresa = new EmpresaRepositorio(_db);
        }
      
        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
