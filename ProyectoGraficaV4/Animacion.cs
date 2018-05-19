using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Animacion
    {
        public Animacion()
        {

        }

        public void avanzarAuto(Grafico grafico, Paint paint)
        {
            for (int i = 0; i < 200; i++)
            {
                if (i < 80)
                {
                    avanzarArriba(grafico, paint);
                }
                if (i >= 80 && i < 120)
                {
                    avanzarYgirar(grafico, paint);
                }
                if (i >= 120 && i < 180)
                {
                    avanzarIzquierda(grafico, paint);
                }
            }

        }

        public void avanzarArriba(Grafico grafico, Paint paint)
        {
            paint.setPen(new Pen(Color.White, 2));
                paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());
            grafico.GetEscenario().getListaDeObjetos()[1].traslacion(0, 3);
            paint.setPen(new Pen(Color.Black, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());

        }

        public void avanzarYgirar(Grafico grafico, Paint paint)
        {
            paint.setPen(new Pen(Color.White, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());
            grafico.GetEscenario().getListaDeObjetos()[1].traslacion(-1, 2);
            grafico.GetEscenario().getListaDeObjetos()[1].rotacion(0.9);
            paint.setPen(new Pen(Color.Black, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());

        }

        public void avanzarYgirarMasLento(Grafico grafico, Paint paint)
        {
            paint.setPen(new Pen(Color.White, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());
            grafico.GetEscenario().getListaDeObjetos()[1].traslacion(-1, 1);
            grafico.GetEscenario().getListaDeObjetos()[1].rotacion(1);
            paint.setPen(new Pen(Color.Black, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());

        }

        public void avanzarYrotar(Grafico grafico, Paint paint)
        {
            paint.setPen(new Pen(Color.White, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());
            grafico.GetEscenario().getListaDeObjetos()[1].traslacion(-1,1);
            grafico.GetEscenario().getListaDeObjetos()[1].rotacion(0.7);
            paint.setPen(new Pen(Color.Black, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());

        }

        public void avanzarIzquierda(Grafico grafico, Paint paint)
        {
            paint.setPen(new Pen(Color.White, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());
            grafico.GetEscenario().getListaDeObjetos()[1].traslacion(-3, 0);
            paint.setPen(new Pen(Color.Black, 2));
            paint.drawObjeto1(grafico.GetEscenario().getListaDeObjetos()[1], grafico.GetEscenario().getPuntoDeReferencia());

        }
    }
}
