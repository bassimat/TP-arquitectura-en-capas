using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class Carrera
    {
        private string _nombre;
        private string _coordinador;
        private int _duracionEnCuatris;
        private HashSet<Materia> _materias = new HashSet<Materia>();


        public Carrera( string nombre )
        {
            this._nombre = nombre;
        }

        public string Nombre
        {
            get { return this._nombre; } 
        }



        public int CantidadDeCuatrimestres
        {
            get { return _duracionEnCuatris; }
            set { _duracionEnCuatris = value; }
        }


        public string Coordinador
        {
            get { return _coordinador; }
            set { _coordinador = value; }
        }


        public bool AgregarMateria( Materia nuevaMateria )
        {
            return this._materias.Add( nuevaMateria );
        }
    }
}
