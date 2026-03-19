using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMaquinas
{
    public class Maquina : Componente
    {
        private List<Componente> _componentes;

        public Maquina(string nombre, string descripcion)
            : base(nombre, descripcion)
        {
            _componentes = new List<Componente>();
        }

        public override void AgregarHijo(Componente c)
        {
            _componentes.Add(c);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _componentes;
        }

        public override int ObtenerPrecio
        {
            get
            {
                int total = 0;
                foreach (var c in _componentes)
                    total += c.ObtenerPrecio;
                return total;
            }
        }
    }
}
