using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Central_911
    {
        private static Central_911 _instance;
        private static readonly object _lock = new object();

        public string Central {  get; private set; }

        private Central_911() 
        {
            Central = "Central 911";
        }

        public static Central_911 Obtener_Instancia()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Central_911();
                    }
                }    
            }
            return _instance;
        }

        public void ConectarLlamada(Operador operador, string tipoEmergencia)
        {
            Console.WriteLine("\nLlamada conectada con el operador" + operador.Nombre);
            operador.AtiendeEmergencia(tipoEmergencia);
        }
    }
}
