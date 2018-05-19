using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Objeto
    {
        private List<Poligono> listaDePoligonos;
        private Punto puntoDeReferencia;

        public Objeto()
        {
            listaDePoligonos = new List<Poligono>();
        }

        public Objeto(List<Poligono> listaDePoligonos)
        {
            this.listaDePoligonos = listaDePoligonos;
        }

        public Objeto(Punto puntoDeReferencia, List<Poligono> listaDePoligonos)
        {
            this.puntoDeReferencia = puntoDeReferencia;
            this.listaDePoligonos = listaDePoligonos;
        }

        public List<Poligono> getListaDePoligonos()
        {
            return this.listaDePoligonos;
        }

        public Punto getPuntoDeReferencia()
        {
            return this.puntoDeReferencia;
        }

        public void setPuntoDeReferencia(Punto nuevoPuntoDeReferencia)
        {
            this.puntoDeReferencia = nuevoPuntoDeReferencia;
        }

        public void setListaDePoligonos(List<Poligono> listaDePoligonos)
        {
            this.listaDePoligonos = listaDePoligonos;
        }

        public void addPoligono(Poligono nuevoPoligono)
        {
            this.listaDePoligonos.Add(nuevoPoligono);
        }

        public Punto sacarPuntoConMenorX()
        {
            Punto puntoConMenorX = listaDePoligonos[0].menorX();
            for (int i = 0; i < listaDePoligonos.Count() - 1; i++)
            {
                Punto puntoAct = listaDePoligonos[i + 1].menorX();
                if (!puntoConMenorX.menorX(puntoAct))
                {
                    puntoConMenorX = puntoAct;
                }
            }
            return puntoConMenorX;
        }

        public Punto sacarPuntoConMenorY()
        {
            Punto puntoConMenorY = listaDePoligonos[0].menorY();
            for (int i = 0; i < listaDePoligonos.Count() - 1; i++)
            {
                Punto puntoAct = listaDePoligonos[i + 1].menorY();
                if (!puntoConMenorY.menorY(puntoAct))
                {
                    puntoConMenorY = puntoAct;
                }
            }
            return puntoConMenorY;
        }

        public Punto sacarPuntoConMayorX()
        {
            Punto puntoConMayorX = listaDePoligonos[0].mayorX();
            for (int i = 0; i < listaDePoligonos.Count() - 1; i++)
            {
                Punto puntoAct = listaDePoligonos[i + 1].mayorX();
                if (!puntoConMayorX.mayorX(puntoAct))
                {
                    puntoConMayorX = puntoAct;
                }
            }
            return puntoConMayorX;
        }

        public Punto sacarPuntoConMayorY()
        {
            Punto puntoConMayorY = listaDePoligonos[0].mayorY();
            for (int i = 0; i < listaDePoligonos.Count() - 1; i++)
            {
                Punto puntoAct = listaDePoligonos[i + 1].mayorY();
                if (!puntoConMayorY.mayorY(puntoAct))
                {
                    puntoConMayorY = puntoAct;
                }
            }
            return puntoConMayorY;
        }

        public void cambiar_A_Relativo(Punto puntoDeReferenciaDelEscenario)
        {
            for (int i = 0; i < listaDePoligonos.Count(); i++)
            {
                listaDePoligonos[i].cambiar_A_Relativo(this.puntoDeReferencia);
            }
            this.puntoDeReferencia.cambiar_A_Relativa(puntoDeReferenciaDelEscenario);
        }

        public void cambiar_A_Absoluto(Punto puntoDeReferenciaDelEscenario)
        {
            this.puntoDeReferencia.cambiar_A_Absoluto(puntoDeReferenciaDelEscenario);

            for (int i = 0; i < listaDePoligonos.Count(); i++)
            {
                listaDePoligonos[i].cambiar_A_Absoluto(this.puntoDeReferencia);
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
            Matriz matriz = new Matriz(angulo);
            Transformaciones rotar = new Transformaciones();

            for (int i = 0; i < listaDePoligonos.Count(); i++)
            {
                rotar.transformar(this.listaDePoligonos[i].getPuntoDeReferencia(), matriz);
                this.listaDePoligonos[i].rotacion(angulo);
            }
        }

        public void escalacion(float factorEscala, int escala)
        {
            Matriz matriz = new Matriz(factorEscala, escala);
            Transformaciones escalar = new Transformaciones();

            for (int i = 0; i < this.listaDePoligonos.Count(); i++)
            {
                escalar.transformar(this.listaDePoligonos[i].getPuntoDeReferencia(), matriz);
                this.listaDePoligonos[i].escalacion(factorEscala, escala);
            }
        }

        public void escalacion(float factorEscala1, float factorEscala2, int escala)
        {
            Matriz matriz = new Matriz(factorEscala1, factorEscala2, escala);
            Transformaciones escalar = new Transformaciones();

            for (int i = 0; i < this.listaDePoligonos.Count(); i++)
            {
                escalar.transformar(this.listaDePoligonos[i].getPuntoDeReferencia(), matriz);
                this.listaDePoligonos[i].escalacion(factorEscala1, factorEscala2, escala);
            }
        }
    }
}
