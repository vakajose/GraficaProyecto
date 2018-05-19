using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaV4
{
    class Paint
    {
        private Graphics graphics;
        private Pen pen;

        public Paint(Graphics graphics)
        {
            this.graphics = graphics;
            this.pen = new Pen(Color.Black, 2);
        }

        public void setPen(Pen pen)
        {
            this.pen = pen;
        }

        public void drawPunto(Punto punto)
        {
            this.graphics.DrawRectangle(pen, new Rectangle((int)punto.X(), (int)punto.Y(), 1, 1));
        }

        public void drawLinea(Punto puntoIni, Punto puntoEnd)
        {
            float puntoIniX = puntoIni.X();
            float puntoIniY = puntoIni.Y();
            float puntoEndX = puntoEnd.X();
            float puntoEndY = puntoEnd.Y();

            this.graphics.DrawLine(pen, puntoIniX, puntoIniY, puntoEndX, puntoEndY);
        }

        public void drawPoligono(Poligono poligono)
        {
            List<Punto> listaDePuntos = poligono.getListaDePuntos();

            for (int i = 0; i < listaDePuntos.Count() - 1; i++)
            {
                Punto puntoIni = listaDePuntos[i];
                Punto puntoEnd = listaDePuntos[i + 1];

                this.drawLinea(puntoIni, puntoEnd);
            }
        }

        public void drawObjeto(Objeto objeto)
        {
            List<Poligono> listaDePoligonos = objeto.getListaDePoligonos();

            for (int i = 0; i < listaDePoligonos.Count(); i++)
            {
                Poligono poligonoAct = listaDePoligonos[i];
                this.drawPoligono(poligonoAct);
            }
        }

        public void drawObjeto1(Objeto objeto, Punto v)
        {
            objeto.cambiar_A_Absoluto(v);
            this.drawObjeto(objeto);
            objeto.cambiar_A_Relativo(v);
        }

        public void drawEscenario(Escenario escenario)
        {
            escenario.cambiar_A_Absoluto();

            List<Objeto> listaDeObjetos = escenario.getListaDeObjetos();

            for (int i = 0; i < listaDeObjetos.Count(); i++)
            {
                Objeto objetoAtc = listaDeObjetos[i];
                this.drawObjeto(objetoAtc);
            }

            escenario.cambiar_A_Relativo();
        }

        public void moverPuntoReferencia(Punto nuevoPuntoRf, Escenario escenario)
        {
            this.clear();
            escenario.setPuntoDeReferencia(nuevoPuntoRf);
            this.drawEscenario(escenario);
            this.drawEjeDeCoordenadas(nuevoPuntoRf);
        }

        public void drawEjeDeCoordenadas(Punto ejeDeCoordenada)
        {
            float X = ejeDeCoordenada.X();
            float Y = ejeDeCoordenada.Y();
            this.drawLinea(new Punto(X, 0), new Punto(X, 1000));
            this.drawLinea(new Punto(0, Y), new Punto(2000, Y));
        }

        public void clear()
        {
            graphics.Clear(Color.White);
        }
    }   
}
