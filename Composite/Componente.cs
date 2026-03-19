using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMaquinas
{
    public abstract class Componente
    {
        string _nombre;
        string _descripcion;

        public Componente(string nombre, string descripcion)
        {
            _nombre = nombre;
            _descripcion = descripcion;
        }

        public string Nombre => _nombre;
        public string Descripcion => _descripcion;

        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerPrecio { get; }
    }
}
