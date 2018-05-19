using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaV4
{
    class Grafico
    {
        private Escenario escenario;
        private Objeto objeto;
        private Poligono poligono;
        private Boolean puntoCentral;

        public Grafico()
        {
            escenario = new Escenario(new Punto(630, 390));
            objeto = new Objeto();
            poligono = new Poligono();
            puntoCentral = true;
        }

        public Escenario GetEscenario()
        {
            return this.escenario;
        }

        public Objeto GetObjeto()
        {
            return this.objeto;
        }

        public Poligono GetPoligono()
        {
            return this.poligono;
        }

        public Boolean GetpuntoCentral()
        {
            return this.puntoCentral;
        }

        public void setEscenario(Escenario nuevoEscenario)
        {
            this.escenario = nuevoEscenario;
        }

        public void setObjeto(Objeto nuevoObjeto)
        {
            this.objeto = nuevoObjeto;
        }

        public void setPoligono(Poligono nuevoPoligono)
        {
            this.poligono = nuevoPoligono;
        }

        public void setPuntoCentral(Boolean nuevoPuntoCentral)
        {
            this.puntoCentral = nuevoPuntoCentral;
        }

        public void CargarEscenario()
        {
            Punto pMeX = this.objeto.sacarPuntoConMenorX();
            Punto pMeY = this.objeto.sacarPuntoConMenorY();
            Punto pMaX = this.objeto.sacarPuntoConMayorX();
            Punto pMaY = this.objeto.sacarPuntoConMayorY();

            float coordenadaX = ((pMaX.X() - pMeX.X()) / 2) + pMeX.X();
            float coordenadaY = ((pMaY.Y() - pMeY.Y()) / 2) + pMeY.Y();

            Punto nuevoPuntoDeReferenciaDelObjeto = new Punto(coordenadaX, coordenadaY);
            this.objeto.setPuntoDeReferencia(nuevoPuntoDeReferenciaDelObjeto);
            this.objeto.cambiar_A_Relativo(this.escenario.getPuntoDeReferencia());

            this.escenario.addObjeto(this.objeto);
            this.objeto = new Objeto();
        }

        public void CargarObjeto()
        {
            Punto pMeX = this.poligono.menorX();
            Punto pMeY = this.poligono.menorY();
            Punto pMaX = this.poligono.mayorX();
            Punto pMaY = this.poligono.mayorY();

            float coordenadaX = ((pMaX.X() - pMeX.X()) / 2) + pMeX.X();
            float coordenadaY = ((pMaY.Y() - pMeY.Y()) / 2) + pMeY.Y();

            Punto nuevoPuntoDeReferenciaDelPoligono = new Punto(coordenadaX, coordenadaY);
            this.poligono.setPuntoDeReferencia(nuevoPuntoDeReferenciaDelPoligono);

            this.objeto.addPoligono(this.poligono);
            this.poligono = new Poligono();
        }

        public void CargarPoligono(Punto nuevoPunto)
        {
            this.poligono.addPunto(nuevoPunto);
        }

        public void cargarListBox(ListBox listbox)
        {
            listbox.Items.Add("Escenario");

            for (int i = 0; i < escenario.getListaDeObjetos().Count(); i++)
            {
                listbox.Items.Add("Objeto-Nro-" + i);
                Objeto objetoAct = escenario.getListaDeObjetos()[i];

                for (int j = 0; j < objetoAct.getListaDePoligonos().Count(); j++)
                {
                    listbox.Items.Add("Poligono-#-" + i + "" + j);
                }
            }
        }

        public void guardarGrafico()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = " texto file|* .txt";
            if (guardar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter bw = new StreamWriter(File.Create(guardar.FileName));
                GuardarGrafico(bw);
                bw.Close();
            }
        }

        private void GuardarGrafico(StreamWriter bw)
        {
            for (int i = 0; i < escenario.getListaDeObjetos().Count(); i++)
            {
                Objeto objeto = escenario.getListaDeObjetos()[i];
                bw.WriteLine("OBJETO");

                for (int j = 0; j < objeto.getListaDePoligonos().Count(); j++)
                {
                    Poligono poligono = objeto.getListaDePoligonos()[j];
                    bw.WriteLine("POLIGONO");

                    for (int k = 0; k < poligono.getListaDePuntos().Count(); k++)
                    {
                        Punto punto = poligono.getListaDePuntos()[k];
                        bw.WriteLine(punto.X().ToString() + ";" + punto.Y().ToString());
                    }
                }
            }
        }

        public void abrirGrafico()
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = " Archivos txt(* .txt)|* .txt";
            abrir.Title = " ABRIR txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader textoLeer = new StreamReader(abrir.FileName);
                this.AbrirGrafico(textoLeer);
            }
            abrir.Dispose();
        }

        private void AbrirGrafico(StreamReader archivo)
        {
            String lineaAct = archivo.ReadLine();
            while (lineaAct == "OBJETO")
            {
                lineaAct = archivo.ReadLine();
                while (lineaAct == "POLIGONO")
                {
                    lineaAct = archivo.ReadLine();
                    while ((lineaAct != "POLIGONO") && (lineaAct != "OBJETO") && (lineaAct != null))
                    {
                        string cadPunto = "";
                        Punto punto = new Punto();
                        for (int i = 0; i < lineaAct.Length; i++)
                        {
                            if (lineaAct[i] == ';')
                            {
                                punto.setX(float.Parse(cadPunto));
                                cadPunto = "";
                                i += 1;
                            }
                            cadPunto = cadPunto + lineaAct[i];
                        }
                        punto.setY(float.Parse(cadPunto));
                        this.CargarPoligono(punto);
                        lineaAct = archivo.ReadLine();
                    }
                    this.CargarObjeto();
                }
                this.CargarEscenario();
            }
        }
    }
}
