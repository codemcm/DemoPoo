using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{

    //Clase: Plantilla para definir objetos
    //Objeto:  Implementacion de una clase (Cuando le asignas valores a las propiedades) Usas la palabra new para crear un objeto
    
    public class Empleado
    {

        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }

        public string Correo { get; set; }
        public  int SalarioDiario { get; set; }

        public int CalcularSalario()
        {
            int SalarioQuincena = SalarioDiario * 15;
            return SalarioQuincena;
        }
        public string MostrarDatos()
        {
            return "Nombre : " + Nombre + " Correo: " + Correo;

        }

    }
}
