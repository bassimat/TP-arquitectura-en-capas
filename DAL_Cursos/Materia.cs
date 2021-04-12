using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class Materia
    {
        Conexion _db = new Conexion();

        public bool Alta( string nombre, int id_Carrera, int cuatrimestre )
        {
            string query = string.Format("INSERT INTO tMateria ([nombre],[idCarrera],[cuatrimestre]) "+
                                         "VALUES ('{0}', {1}, {2})",
                                         nombre, id_Carrera, cuatrimestre);
            if ( 1 != this._db.EscribirPorComando( query ) )
                return false;

            return true;
        }


        public DataTable Reporte()
        {
            return this._db.LeerPorStoreProcedure("sp_reporteMateria");
        }
    }
}
