using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Poligono
    {
        private List<Punto> listaDePuntos;
        private Punto puntoDeReferencia;

        public Poligono()
        {
            this.listaDePuntos = new List<Punto>();
        }

        public Poligono(List<Punto> listaDePuntos)
        {
            this.listaDePuntos = listaDePuntos;
        }

        public Poligono(Punto puntoDeReferencia, List<Punto> listaDePuntos)
        {
            this.listaDePuntos = listaDePuntos;
            this.puntoDeReferencia = puntoDeReferencia;
        }

        public List<Punto> getListaDePuntos()
        {
            return this.listaDePuntos;
        }

        public Punto getPuntoDeReferencia()
        {
            return this.puntoDeReferencia;
        }

        public void setPuntoDeReferencia(Punto nuevoPuntoDeReferencia)
        {
            this.puntoDeReferencia = nuevoPuntoDeReferencia;
        }

        public void setListaDePuntos(List<Punto> listaDePuntos)
        {
            this.listaDePuntos = listaDePuntos;
        }

        public void addPunto(Punto nuevoPunto)
        {
            this.listaDePuntos.Add(nuevoPunto);
        }

        public Boolean estaVacioPoligono()
        {
            return (this.listaDePuntos.Count() == 0);
        }

        public Punto menorX()
        {
            Punto punto1 = listaDePuntos[0];
            for (int i = 0; i < listaDePuntos.Count() - 1; i++)
            {
                if (!punto1.menorX(listaDePuntos[i + 1]))
                {
                    punto1 = listaDePuntos[i + 1];
                }
            }
            return punto1;
        }

        public Punto menorY()
        {
            Punto punto1 = listaDePuntos[0];
            for (int i = 0; i < listaDePuntos.Count() - 1; i++)
            {
                if (!punto1.menorY(listaDePuntos[i + 1]))
                {
                    punto1 = listaDePuntos[i + 1];
                }
            }
            return punto1;
        }

        public Punto mayorX()
        {
            Punto punto1 = listaDePuntos[0];
            for (int i = 0; i < listaDePuntos.Count() - 1; i++)
            {
                if (!punto1.mayorX(listaDePuntos[i + 1]))
                {
                    punto1 = listaDePuntos[i + 1];
                }
            }
            return punto1;
        }

        public Punto mayorY()
        {
            Punto punto1 = listaDePuntos[0];
            for (int i = 0; i < listaDePuntos.Count() - 1; i++)
            {
                if (!punto1.mayorY(listaDePuntos[i + 1]))
                {
                    punto1 = listaDePuntos[i + 1];
                }
            }
            return punto1;
        }

        public void cambiar_A_Relativo(Punto puntoDeReferenciaDelObjeto)
        {
            for (int i = 0; i < listaDePuntos.Count(); i++)
            {
                listaDePuntos[i].cambiar_A_Relativa(this.puntoDeReferencia);
            }
            this.puntoDeReferencia.cambiar_A_Relativa(puntoDeReferenciaDelObjeto);
        }

        public void cambiar_A_Absoluto(Punto puntoDeReferenciaDelObjeto)
        {
            this.puntoDeReferencia.cambiar_A_Absoluto(puntoDeReferenciaDelObjeto);

            for (int i = 0; i < listaDePuntos.Count(); i++)
            {
                listaDePuntos[i].cambiar_A_Absoluto(this.puntoDeReferencia);
            }
        }

        public void traslacion(float tx, float ty)
        {
            Matriz matriz = new Matriz(tx, ty);
            Transformaciones trasladar = new Transformaciones();

            trasladar.transformar(this.puntoDeReferencia, matriz);
        }

        public void rotacion(double angulo)
        {
            Matriz R = new Matriz(angulo);
            Transformaciones rotar = new Transformaciones();

            for (int i = 0; i < listaDePuntos.Count(); i++)
            {
                rotar.transformar(listaDePuntos[i], R);
            }
        }

        public void escalacion(float factorEscala, int escala)
        {
            Matriz matriz = new Matriz(factorEscala, escala);
            Transformaciones escalar = new Transformaciones();

            for (int i = 0; i < listaDePuntos.Count(); i++)
            {
                escalar.transformar(listaDePuntos[i], matriz);
            }
        }

        public void escalacion(float factorEscala1, float factorEscala2, int escala)
        {
            Matriz matriz = new Matriz(factorEscala1, factorEscala2, escala);
            Transformaciones escalar = new Transformaciones();

            for (int i = 0; i < listaDePuntos.Count(); i++)
            {
                escalar.transformar(listaDePuntos[i], matriz);
            }
        }
    }
}
