using System;
using System.Collections.Generic;

namespace CompositeMaquinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ARMADO DE COMPUTADORAS ===");
                Console.WriteLine("1. PC Básica");
                Console.WriteLine("2. PC Estándar");
                Console.WriteLine("3. PC de Lujo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Componente maquina = null;

                switch (opcion)
                {
                    case "1":
                        maquina = CrearBasica();
                        break;
                    case "2":
                        maquina = CrearEstandar();
                        break;
                    case "3":
                        maquina = CrearLujo();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción inválida...");
                        Console.ReadKey();
                        continue;
                }

                MostrarDetalle(maquina);
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        static Componente CrearBasica()
        {
            var pc = new Maquina("PC Básica", "Equipo económico para tareas simples como navegación, ofimática y multimedia ligera");

            pc.AgregarHijo(SeleccionarCPU("basica"));
            pc.AgregarHijo(SeleccionarRAM("basica"));
            pc.AgregarHijo(SeleccionarDisco("basica"));
            pc.AgregarHijo(SeleccionarGPU("basica"));

            return pc;
        }

        static Componente CrearEstandar()
        {
            var pc = new Maquina("PC Estándar", "Equipo balanceado ideal para multitarea, estudio, trabajo y gaming moderado");

            pc.AgregarHijo(SeleccionarCPU("estandar"));
            pc.AgregarHijo(SeleccionarRAM("estandar"));
            pc.AgregarHijo(SeleccionarDisco("estandar"));
            pc.AgregarHijo(SeleccionarGPU("estandar"));

            return pc;
        }

        static Componente CrearLujo()
        {
            var pc = new Maquina("PC de Lujo", "Equipo de alto rendimiento diseñado para gaming avanzado, edición y tareas exigentes");

            pc.AgregarHijo(SeleccionarCPU("lujo"));
            pc.AgregarHijo(SeleccionarRAM("lujo"));
            pc.AgregarHijo(SeleccionarDisco("lujo"));
            pc.AgregarHijo(SeleccionarGPU("lujo"));

            return pc;
        }


        static Pieza SeleccionarComponente(string tipo, List<Pieza> opciones)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== Seleccionar {tipo} ===\n");

                for (int i = 0; i < opciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i].Nombre}");
                    Console.WriteLine($"   {opciones[i].Descripcion}");
                    Console.WriteLine($"   Precio: ${opciones[i].ObtenerPrecio}\n");
                }

                Console.Write("Elige una opción: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int opcion) &&
                    opcion >= 1 && opcion <= opciones.Count)
                {
                    return opciones[opcion - 1];
                }

                Console.WriteLine("Opción inválida...");
                Console.ReadKey();
            }
        }


        static Pieza SeleccionarCPU(string gama)
        {
            List<Pieza> opciones;

            if (gama == "basica")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("Intel i3-12100F", "Procesador de 4 núcleos ideal para tareas básicas, navegación y oficina", 1800),
                    new Pieza("Ryzen 3 4100", "CPU económica de buen rendimiento para uso diario y aplicaciones ligeras", 1600),
                    new Pieza("Intel i3-10100", "Procesador confiable para trabajo de oficina y multimedia", 1500)
                };
            }
            else if (gama == "estandar")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("Intel i5-12400F", "Procesador de 6 núcleos excelente para multitarea y gaming moderado", 2800),
                    new Pieza("Ryzen 5 5600", "Gran rendimiento en juegos y aplicaciones exigentes", 3000),
                    new Pieza("Intel i5-12600KF", "CPU de alto rendimiento con excelente balance entre potencia y precio", 3500)
                };
            }
            else
            {
                opciones = new List<Pieza>
                {
                    new Pieza("Intel i7-13700K", "Procesador de alto rendimiento ideal para gaming avanzado y edición", 7000),
                    new Pieza("Ryzen 7 5800X", "Excelente para tareas pesadas como renderizado y streaming", 6500),
                    new Pieza("Intel i9-13900K", "Procesador extremo para máximo rendimiento en cualquier escenario", 8500)
                };
            }

            return SeleccionarComponente("CPU", opciones);
        }

        static Pieza SeleccionarRAM(string gama)
        {
            List<Pieza> opciones;

            if (gama == "basica")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("8GB DDR4", "Memoria suficiente para tareas básicas y uso cotidiano", 1200),
                    new Pieza("12GB DDR4", "Mejor desempeño en multitarea ligera", 1500),
                    new Pieza("8GB DDR5", "Memoria de nueva generación con mayor velocidad", 1800)
                };
            }
            else if (gama == "estandar")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("16GB DDR4", "Capacidad ideal para multitarea y gaming actual", 2300),
                    new Pieza("16GB DDR5", "Mayor velocidad y mejor rendimiento en aplicaciones modernas", 2800),
                    new Pieza("32GB DDR4", "Excelente para multitarea intensiva y software exigente", 3500)
                };
            }
            else
            {
                opciones = new List<Pieza>
                {
                    new Pieza("32GB DDR5", "Memoria de alto rendimiento para gaming y productividad avanzada", 4500),
                    new Pieza("64GB DDR4", "Gran capacidad para trabajos profesionales pesados", 6000),
                    new Pieza("64GB DDR5", "Máximo rendimiento y capacidad para tareas extremas", 8000)
                };
            }

            return SeleccionarComponente("RAM", opciones);
        }

        static Pieza SeleccionarDisco(string gama)
        {
            List<Pieza> opciones;

            if (gama == "basica")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("SSD 256GB", "Almacenamiento rápido para sistema operativo y programas básicos", 800),
                    new Pieza("SSD 500GB", "Buen equilibrio entre velocidad y capacidad", 1200),
                    new Pieza("HDD 1TB", "Gran capacidad de almacenamiento a menor costo", 900)
                };
            }
            else if (gama == "estandar")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("SSD 1TB", "Amplio espacio con excelente velocidad", 2500),
                    new Pieza("NVMe 1TB", "Almacenamiento ultra rápido para mejor rendimiento del sistema", 3000),
                    new Pieza("SSD 2TB", "Gran capacidad ideal para juegos y archivos pesados", 3500)
                };
            }
            else
            {
                opciones = new List<Pieza>
                {
                    new Pieza("NVMe 2TB", "Velocidad extrema para cargas rápidas y alto rendimiento", 4000),
                    new Pieza("NVMe 4TB", "Capacidad masiva con tecnología de última generación", 8000),
                    new Pieza("SSD 2TB Pro", "Almacenamiento profesional optimizado para rendimiento continuo", 5000)
                };
            }

            return SeleccionarComponente("Disco", opciones);
        }

        static Pieza SeleccionarGPU(string gama)
        {
            List<Pieza> opciones;

            if (gama == "basica")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("Gráficos Integrados", "Solución gráfica incluida en el procesador para tareas básicas", 0),
                    new Pieza("GTX 1650", "Tarjeta gráfica básica para juegos ligeros y multimedia", 3500),
                    new Pieza("RX 6400", "GPU económica con buen rendimiento en juegos básicos", 3000)
                };
            }
            else if (gama == "estandar")
            {
                opciones = new List<Pieza>
                {
                    new Pieza("RTX 3060", "Excelente rendimiento en juegos modernos y aplicaciones gráficas", 8000),
                    new Pieza("RX 6600", "Gran desempeño en gaming con buena relación calidad-precio", 7500),
                    new Pieza("RTX 4060", "Tecnología reciente con mejor eficiencia y rendimiento", 9000)
                };
            }
            else
            {
                opciones = new List<Pieza>
                {
                    new Pieza("RTX 4070", "Alto rendimiento para gaming en alta calidad y resolución", 15000),
                    new Pieza("RTX 4080", "Potencia extrema para juegos AAA y trabajo profesional", 30000),
                    new Pieza("RTX 4090", "La mejor GPU del mercado para rendimiento máximo sin compromisos", 60000)
                };
            }

            return SeleccionarComponente("GPU", opciones);
        }

        static void MostrarDetalle(Componente maquina)
        {
            Console.Clear();
            Console.WriteLine($"Máquina: {maquina.Nombre}");
            Console.WriteLine($"Descripción: {maquina.Descripcion}");
            Console.WriteLine("\nComponentes seleccionados:\n");

            foreach (var comp in maquina.ObtenerHijos())
            {
                Console.WriteLine($"- {comp.Nombre}");
                Console.WriteLine($"  {comp.Descripcion}");
                Console.WriteLine($"  Precio: ${comp.ObtenerPrecio}\n");
            }

            Console.WriteLine($"PRECIO TOTAL: ${maquina.ObtenerPrecio}");
        }
    }
}
