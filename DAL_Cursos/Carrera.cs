using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Carrera
    {
        Conexion _db = new Conexion();
        DataRow _fila;

        public Carrera( DataRow fila_tCarrera )
        {
            this._fila = fila_tCarrera;
        }


        public int ID
        {
            get { return this._fila.Field<int>("idCarrera"); }
        }

        public string Nombre
        {
            get { return this._fila.Field<string>("nombre"); }
        }

        public string Coordinador
        {
            get { return this._fila.Field<string>("coordinador"); }
        }

        public int Cuatrimestres
        {
            get { return this._fila.Field<int>("cuatrimestres"); }
        }
        

        public static List<Carrera> ObtenerCarrerasDB()
        {
            List<Carrera> dbCarrerasDAL = new List<Carrera>();
            DataTable dtCarreras = (new Conexion()).LeerPorComando("SELECT	* FROM  tCarrera;");

            foreach (DataRow fila in dtCarreras.Rows)
            {
                dbCarrerasDAL.Add( new Carrera(fila) );
            }
            return dbCarrerasDAL;
        }
    }
}
