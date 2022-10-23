using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClassNegocio
    {
        ClassDatos objd = new ClassDatos();

        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_buscar_clientes(Capa_Datos.ClassEntidad obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String N_mantenimiento_cliente(Capa_Datos.ClassEntidad obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }

        public string semana13_sistemadeventas(Capa_Entidad.ClassEntidad objent)
        {
            throw new NotImplementedException();
        }

        public DataTable N_buscar_cliente(Capa_Entidad.ClassEntidad objent)
        {
            throw new NotImplementedException();
        }
    }
}
