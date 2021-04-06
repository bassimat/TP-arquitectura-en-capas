using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Materia
    {
        public bool Alta( string nombre, int id_Carrera, int cuatrimestre )
        {
            Conexion db = new Conexion();
            string query = string.Format("INSERT INTO tMateria ([nombre],[idCarrera],[cuatrimestre]) "+
                                         "VALUES ('{0}', {1}, {2})",
                                         nombre, id_Carrera, cuatrimestre);
            if ( 1 != db.EscribirPorComando( query ) )
                return false;

            return true;
        }
    }
}
