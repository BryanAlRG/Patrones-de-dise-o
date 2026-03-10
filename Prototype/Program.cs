using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExamenPrototype prototipopatrones = new PatronesPrototype();
            ExamenPrototype prototipoinvestigacion = new InvestigacionPrototype();
            ExamenPrototype prototiporedes = new RedesPrototype();
            ExamenPrototype AutomatasPrototipo = new prototipoAutomatas();
            ExamenPrototype prototipoIS = new ISPrototype();
            ExamenPrototype prototipoProlog = new PrologPrototype();
            ExamenPrototype prototipoEcuaciones = new EcuacionesPrototype();
            ExamenPrototype prototipoPW = new PWPrototype();

            prototipopatrones.clave = "DSF-2101";
            prototipopatrones.Salon = "9205/91L5";
            prototipopatrones.Hora = "3:00-4:00";
            prototipopatrones.Asignatura = "Patrones de Diseño";
            prototipopatrones.Docente = "MARIBEL GUERRERO LUIS";
            Console.WriteLine(prototipopatrones.VerExamen());

            prototipoinvestigacion.clave = "ACA-0910";
            prototipoinvestigacion.Salon = "9306";
            prototipoinvestigacion.Hora = "4:00-5:00";
            prototipoinvestigacion.Asignatura = "Taller de Investigacion II";
            prototipoinvestigacion.Docente = "Jose Sergio Magdaleno Palencia";
            Console.WriteLine( prototipoinvestigacion.VerExamen());

            prototiporedes.clave = "SCA-1002";
            prototiporedes.Salon = "9305";
            prototiporedes.Hora = "6:00-7:00";
            prototiporedes.Asignatura = "Administracion de Redes";
            prototiporedes.Docente = "Hector Alonso Miramontes Miramontes";
            Console.WriteLine( prototiporedes.VerExamen());

            AutomatasPrototipo.clave = "SCD-1016";
            AutomatasPrototipo.Salon = "9202";
            AutomatasPrototipo.Hora = "2:00-3:00";
            AutomatasPrototipo.Asignatura = "Lenguaje y Automatas II";
            AutomatasPrototipo.Docente = "Erasmo Estrada Peña";
            Console.WriteLine( AutomatasPrototipo.VerExamen());

            prototipoIS.clave = "SCD-1011";
            prototipoIS.Salon = "9305";
            prototipoIS.Hora = "7:00-8:00";
            prototipoIS.Asignatura = "Ingeniera de Software";
            prototipoIS.Docente = "Hector Javier Hinojosa Galvan";
            Console.WriteLine( prototipoIS.VerExamen());

            prototipoProlog.clave = "SCC-1019";
            prototipoProlog.Salon = "9310";
            prototipoProlog.Hora = "5:00-6:00";
            prototipoProlog.Asignatura = "Programacion Logica y Funcional";
            prototipoProlog.Docente = "Luis Alfonso Gaxiola Vega";
            Console.WriteLine( prototipoProlog.VerExamen());

            prototipoEcuaciones.clave = "ACF-0905";
            prototipoEcuaciones.Salon = "9305";
            prototipoEcuaciones.Hora = "1:00-2:00";
            prototipoEcuaciones.Asignatura = "Ecuaciones Diferenciales";
            prototipoEcuaciones.Docente = "Jaguar";
            Console.WriteLine(prototipoEcuaciones.VerExamen());

            prototipoPW.clave = "AEB-1055";
            prototipoPW.Salon = "9305";
            prototipoPW.Hora = "8:00-9:00";
            prototipoPW.Asignatura = "Programacion WEB";
            prototipoPW.Docente = "Jose Jonathan Perez Castro";

            Console.ReadKey();
        }

        public abstract class ExamenPrototype
        {
            protected string _clave;
            protected string _Salon;
            protected string _Hora;
            protected string _Asignatura;
            protected string _Docente;
            public string clave { set => _clave = value; }
            public string Salon { set => _Salon = value; }
            public string Hora { set => _Hora = value; }
            public string Asignatura { set => _Asignatura = value; }
            public string Docente { set => _Docente = value; }
            public abstract ExamenPrototype Clone();
            public abstract string VerExamen();
        }


        public class PatronesPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (PatronesPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }

        public class InvestigacionPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (InvestigacionPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }

        }

        public class RedesPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (RedesPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }

        public class prototipoAutomatas : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (prototipoAutomatas)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }

        public class ISPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (ISPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }

        public class PrologPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (PrologPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }

        public class EcuacionesPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (EcuacionesPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }

        public class PWPrototype : ExamenPrototype
        {
            public override ExamenPrototype Clone()
            {
                return (PWPrototype)this.MemberwiseClone();
            }
            public override string VerExamen()
            {
                return $"clave {_clave} Salon {_Salon} Hora {_Hora} Asignatura {_Asignatura} Docente {_Docente}";
            }
        }
    }
}
