using Microsoft.EntityFrameworkCore;
using SistemaGestion.AccesoDatos.Data;
using SistemaGestion.AccesoDatos.Repositorio.IRepositorio;
using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.AccesoDatos.Repositorio
{
    public class EmpresaRepositorio : Repositorio<Empresa>, IEmpresaRepositorio
    {

        private readonly ApplicationDbContext _db;

        public EmpresaRepositorio(ApplicationDbContext db) : base(db)
        {
                _db = db;   
        }
        public void Actualizar(Empresa empresa)
        {
            var empresaBD = _db.Empresas.FirstOrDefault(b => b.Id == empresa.Id);
            if(empresaBD != null)
            {
                empresaBD.Nombre = empresa.Nombre;
                empresaBD.Ruc = empresa.Ruc;
                empresaBD.Email = empresa.Email;
                empresaBD.Telefono = empresa.Telefono;  
                empresaBD.Actividad = empresa.Actividad;
                empresaBD.NEmpleados = empresa.NEmpleados;
                empresaBD.Estado = empresa.Estado;
                _db.SaveChanges();
            }
        }
    }
}
