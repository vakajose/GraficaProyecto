using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Escenario
    {
        private List<Objeto> listaDeObjetos;
        private Punto puntoDeReferencia;

        public Escenario()
        {
            listaDeObjetos = new List<Objeto>();
        }

        public Escenario(Punto puntoDeReferencia)
        {
            this.puntoDeReferencia = puntoDeReferencia;
            listaDeObjetos = new List<Objeto>();
        }

        public Escenario(List<Objeto> listaDeObjetos)
        {
            this.listaDeObjetos = listaDeObjetos;
        }

        public Escenario(Punto puntoDeReferencia, List<Objeto> listaDeObjetos)
        {
            this.puntoDeReferencia = puntoDeReferencia;
            this.listaDeObjetos = listaDeObjetos;
        }

        public List<Objeto> getListaDeObjetos()
        {
            return this.listaDeObjetos;
        }

        public Punto getPuntoDeReferencia()
        {
            return this.puntoDeReferencia;

        }

        public void setListaDeObjetos(List<Objeto> listaDeObjetos)
        {
            this.listaDeObjetos = listaDeObjetos;
        }

        public void setPuntoDeReferencia(Punto nuevoPuntoDeReferencia)
        {

            float ejeX = nuevoPuntoDeReferencia.X() - this.puntoDeReferencia.X();
            float ejeY = nuevoPuntoDeReferencia.Y() - this.puntoDeReferencia.Y();

            this.puntoDeReferencia.setPuntoDeReferenciaDelEscenario(new Punto(ejeX, ejeY));
        }

        public void setObjeto(int posicion, Objeto objeto)
        {
            this.listaDeObjetos[posicion] = objeto;
        }

        public void addObjeto(Objeto nuevoObjeto)
        {
            this.listaDeObjetos.Add(nuevoObjeto);
        }

        public void cambiar_A_Relativo()
        {

            for (int i = 0; i < listaDeObjetos.Count(); i++)
            {
                listaDeObjetos[i].cambiar_A_Relativo(this.puntoDeReferencia);
            }
        }

        public void cambiar_A_Absoluto()
        {
            for (int i = 0; i < listaDeObjetos.Count(); i++)
            {
                listaDeObjetos[i].cambiar_A_Absoluto(this.puntoDeReferencia);
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

            for (int i = 0; i < this.listaDeObjetos.Count(); i++)
            {
                rotar.transformar(this.listaDeObjetos[i].getPuntoDeReferencia(), matriz);
                this.listaDeObjetos[i].rotacion(angulo);
            }
        }

        public void escalacion(float factorEscala, int escala)
        {
            Matriz matriz = new Matriz(factorEscala, escala);
            Transformaciones escalar = new Transformaciones();

            for (int i = 0; i < this.listaDeObjetos.Count(); i++)
            {
                escalar.transformar(this.listaDeObjetos[i].getPuntoDeReferencia(), matriz);
                this.listaDeObjetos[i].escalacion(factorEscala, escala);
            }
        }

        public void escalacion(float factorEscala1, float factorEscala2, int escala)
        {
            Matriz matriz = new Matriz(factorEscala1, factorEscala2, escala);
            Transformaciones escalar = new Transformaciones();

            for (int i = 0; i < this.listaDeObjetos.Count(); i++)
            {
                escalar.transformar(this.listaDeObjetos[i].getPuntoDeReferencia(), matriz);
                this.listaDeObjetos[i].escalacion(factorEscala1, factorEscala2, escala);
            }
        }

    }
}
