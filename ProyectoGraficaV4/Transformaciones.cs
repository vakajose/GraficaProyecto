using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Transformaciones
    {

        public Transformaciones()
        {

        }

        public void transformar(Punto punto, Matriz matriz)
        {
            float ejeX = punto.X();
            float ejeY = punto.Y();

            punto.setX((ejeX * matriz.getElemento(0, 0)) +
                       (ejeY * matriz.getElemento(1, 0)) +
                       (1 * matriz.getElemento(2, 0)));
            punto.setY((ejeX * matriz.getElemento(0, 1)) +
                       (ejeY * matriz.getElemento(1, 1)) +
                       (1 * matriz.getElemento(2, 1)));
        }
    }
}
