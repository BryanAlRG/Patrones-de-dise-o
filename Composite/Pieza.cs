using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMaquinas
{
    public class Pieza : Componente
    {
        int _precio;

        public Pieza(string nombre, string descripcion, int precio)
            : base(nombre, descripcion)
        {
            _precio = precio;
        }

        public override void AgregarHijo(Componente c) { }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerPrecio => _precio;
    }
}
