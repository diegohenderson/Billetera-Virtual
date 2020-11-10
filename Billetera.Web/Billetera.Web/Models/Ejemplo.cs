using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billetera.Web.Models
{
    public class Ejemplo
    {
        private int id;
        private string nombre;
        private string apellido;
        public Ejemplo(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Ejemplo()
        {
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public override string ToString()
        {
            return $"{apellido}, {nombre}";
        }
    }
}