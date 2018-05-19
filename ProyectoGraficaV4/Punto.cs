using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Punto
    {
        private float x;
        private float y;
        private float z;

        public Punto()
        {
        }

        public Punto(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Punto(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float X()
        {
            return this.x;
        }

        public float Y()
        {
            return this.y;
        }

        public float Z()
        {
            return this.z;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public void setZ(float z)
        {
            this.z = z;
        }

        public Boolean menorX(Punto punto2)
        {
            if (this.X() <= punto2.X())
            {
                return true;
            }
            return false;
        }

        public Boolean menorY(Punto punto2)
        {
            if (this.Y() <= punto2.Y())
            {
                return true;
            }
            return false;
        }

        public Boolean mayorX(Punto punto2)
        {
            if (this.X() >= punto2.X())
            {
                return true;
            }
            return false;
        }

        public Boolean mayorY(Punto punto2)
        {
            if (this.Y() >= punto2.Y())
            {
                return true;
            }
            return false;
        }

        public void cambiar_A_Relativa(Punto puntoDeReferencia)
        {
            this.x = this.x - puntoDeReferencia.X();
            this.y = (this.y - puntoDeReferencia.Y()) * -1;
        }

        public void cambiar_A_Absoluto(Punto puntoDeReferencia)
        {
            this.x = this.x + puntoDeReferencia.X();
            this.y = (this.y - puntoDeReferencia.Y()) * -1;
        }

        public void setPuntoDeReferenciaDelEscenario(Punto nuevoPuntoDeReferenciaDelEscenario)
        {
            this.x = this.x + nuevoPuntoDeReferenciaDelEscenario.X();
            this.y = this.y + nuevoPuntoDeReferenciaDelEscenario.Y();
        }
    }
}
