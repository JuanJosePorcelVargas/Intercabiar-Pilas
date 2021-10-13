using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercabiar_Pilas
{

    class Intercambio
    {
        public void intercambiar(Pila mensajero ,Pila mensajero2 )

        {
            int auxiliar = 0;
            for (int i=0;i<5;i++)
            {
                auxiliar = mensajero.lista[i];
                mensajero.lista[i] = mensajero2.lista[i];
                mensajero2.lista[i] = auxiliar;

            }

        }




    }
}
