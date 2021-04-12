using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BLL
{
    public class Materia : Entity
    {
        private string _nombre;
        private Carrera _carrera;
        private int _sumaCuatris;

        

        public Materia( string nombre)
            : base(nombre)
        {
            this._nombre = nombre;
        }


        public string Nombre
        { 
            get { return this._nombre; }
        }


        public Carrera Carrera
        {
            get { return _carrera; }
            set {
                if (value != null && 
                    value.AgregarMateria( this ) )
                {
                    this._carrera = value;
                }
            }
        }


        public bool SetMomentoDeLaCarrera( Carrera carrera, int anio, int cuatrimestre)
        {
            this.Carrera = carrera;
            return this.SetMomentoDeLaCarrera(anio, cuatrimestre);
        }


        public bool SetMomentoDeLaCarrera( int anio, int cuatrimestre )
        {
            int conversion;

            if (anio < 1 || cuatrimestre < 1 || cuatrimestre > 2)
                return false;

            anio--;
            // Pasaje de 1 año a 2 cuatrimestres más los cuatrimestres que se indiquen
            conversion = anio * 2 + cuatrimestre;

            if (this.Carrera == null ||
                conversion > this.Carrera.CantidadDeCuatrimestres)
                return false;

            this._sumaCuatris = conversion;
            return true;
        }

        public int Anio
        {
            get { return (this._sumaCuatris + 1) / 2; }
        }

        public int Cuatrimestre
        {
            get { return (this._sumaCuatris + 1) % 2 + 1 ; }
        }


        public bool Persistir()
        {
            DAL.Materia dbMateriaDAL = new DAL.Materia();
            return dbMateriaDAL.Alta(this.Nombre, this.Carrera._id, this._sumaCuatris);
        }


        public static DataTable ObtenerReporte()
        {
            return (new DAL.Materia()).Reporte();
        }
    }
}
