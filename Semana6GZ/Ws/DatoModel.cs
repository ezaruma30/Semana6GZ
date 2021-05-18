using System;
using System.Collections.Generic;
using System.Text;

namespace Semana6GZ.Ws
{
    class DatoModel
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
