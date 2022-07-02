using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    //Herencia: Mecanismo que usa la POO, para reutilizar código; donde una clase padre o super clase
    //hereda o transmite sus metodos y propiedades a una clase hijo.

    //encapsulamiento: encerrar funcionalidad.
    //Ocultar o aislar funcionalidad, es como una caja negra donde pedimos algo y nos devuelve un resultado, sin saber que paso internamente.

    //polimorfismo: Una cosa se comporte de diferente manera; ejemplo: abrir una puerta y abrir una ventana

    //abstracción: Capacidad de entender un proceso de la vida real y llevarla a codigo
    public class Vendedor : Empleado
    {

        //Constructor
        //Metodo especial que se utiliza para inicializar las propiedades de un objeto, y se llama igual que la clase;
        //no tiene tipo de retorno.
        //se ejecuta cada vez que se crea un objeto
        public Vendedor()
        {
            
        }

        //Diferencia entre sobreescritura y sobrecarga
        //sobrecarga: se puede tener mas de un metodo con el mismo nombre pero diferente numero de parametros
        //sobreescritura: cuando una clase hijo oculta un metodo o propiedad de la clase padre y utiliza el propio

        public void Saludar()
        {

        }

        public void Saludar(string Nombre)
        {

        }

        
        public new virtual void CalcularSalario()
        {

        }

    }
}
