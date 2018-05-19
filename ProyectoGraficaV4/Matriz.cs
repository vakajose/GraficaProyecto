using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Matriz
    {
        private float[,] matriz;

        public Matriz(float tx, float ty)
        {
            matriz = new float[,]{ {  1,     0, 0 },
                                   {  0,     1, 0 },
                                   { tx,    ty, 0 }};
        }

        public Matriz(double angulo)
        {
            angulo = angulo * Math.PI / 180.0;

            matriz = new float[,] { { (float)( Math.Cos(angulo)), (float)(Math.Sin(angulo)), 0 },
                                    { (float)(-Math.Sin(angulo)), (float)(Math.Cos(angulo)), 0 },
                                    {                          0,                         0, 1 } };

        }

        public Matriz(float factorDeEscala, int s)
        {
            if (s == 1)
            {
                matriz = new float[,] { { factorDeEscala,              0, 0 },
                                        {              0, factorDeEscala, 0 },
                                        {              0,              0, 1 }};
            }
            else
            {
                matriz = new float[,] { { 1/factorDeEscala,                0, 0 },
                                        {                0, 1/factorDeEscala, 0 },
                                        {                0,                0, 1 }};
            }

        }

        public Matriz(float factorDeEscala1, float factorDeEscala2, int s)
        {
            if (s == 1)
            {
                matriz = new float[,] { { factorDeEscala1,              0, 0 },
                                        {              0, factorDeEscala2, 0 },
                                        {              0,              0, 1 }};
            }
            else
            {
                matriz = new float[,] { { 1/factorDeEscala1,                0, 0 },
                                        {                0, 1/factorDeEscala2, 0 },
                                        {                0,                0, 1 }};
            }
        }

        public float getElemento(int i, int j)
        {
            return this.matriz[i, j];
        }
    }
}
