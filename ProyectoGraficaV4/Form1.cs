using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaV4
{
    public partial class Form1 : Form
    {
        Grafico grafico;
        Paint paint;
        Animacion animacion;
        int contador;

        public Form1()
        {
            InitializeComponent();
            this.grafico = new Grafico();
            this.paint = new Paint(CreateGraphics());
            this.animacion = new Animacion();
            this.contador = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.BackColor = Color.White;
            this.paint = new Paint(CreateGraphics());
            panel1.Width = 2000;
            panel1.Height = 40;
            panel1.Location = new Point(0, 20);
            listBox1.Width = 100;
            listBox1.Height = 702;
            listBox2.Width = 100;
            listBox2.Height = 702;
            listBox3.Width = 100;
            listBox3.Height = 702;
            listBox2.Location = new Point(-100, 25);
            listBox3.Location = new Point(-100, 25);
            listBox1.Location = new Point(-100, 25);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.grafico.GetpuntoCentral())
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.grafico.CargarObjeto();
                }

                if (e.Button == MouseButtons.Middle)
                {
                    this.grafico.CargarEscenario();
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (this.grafico.GetPoligono().estaVacioPoligono())
                    {
                        Punto puntoActual = new Punto(e.X, e.Y);
                        this.paint.drawPunto(puntoActual);
                        this.grafico.CargarPoligono(puntoActual);
                    }
                    else
                    {
                        Punto puntoIni = this.grafico.GetPoligono().getListaDePuntos().Last();
                        Punto puntoEnd = new Punto(e.X, e.Y);
                        this.paint.drawLinea(puntoIni, puntoEnd);
                        this.grafico.CargarPoligono(puntoEnd);
                    }
                }
            }
            else
            {
                this.paint.moverPuntoReferencia(new Punto(e.X, e.Y), this.grafico.GetEscenario());
            }
            listBox1.Location = new Point(-100, 25);
            listBox1.Items.Clear();
            listBox2.Location = new Point(-100, 25);
            listBox2.Items.Clear();
            listBox3.Location = new Point(-100, 25);
            listBox3.Items.Clear();
        }

        private void ejeDeCoordenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grafico.GetpuntoCentral())
            {
                this.paint.drawEjeDeCoordenadas(this.grafico.GetEscenario().getPuntoDeReferencia());
                this.grafico.setPuntoCentral(false);
            }
            else
            {
                this.paint.clear();
                this.paint.drawEscenario(this.grafico.GetEscenario());
                this.grafico.setPuntoCentral(true);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grafico = new Grafico();
            this.paint.clear();
        }

        private void traslacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Location = new Point(0, 60);
            this.grafico.cargarListBox(listBox1);
            listBox2.Location = new Point(-100, 25);
            listBox3.Location = new Point(-100, 25);
            listBox2.Items.Clear();
        }

        private void rotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Location = new Point(0, 60);
            this.grafico.cargarListBox(listBox2);
            listBox1.Location = new Point(-100, 25);
            listBox3.Location = new Point(-100, 25);
            listBox1.Items.Clear();
        }

        private void escalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Location = new Point(0, 60);
            this.grafico.cargarListBox(listBox3);
            listBox1.Location = new Point(-100, 25);
            listBox2.Location = new Point(-100, 25);
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paint.clear();
            int longitud = listBox1.SelectedItem.ToString().Length;
            switch (longitud)
            {
                case 9:
                    this.grafico.GetEscenario().traslacion(30, -30);
                    break;

                case 12:
                    int posicionDelObjeto = int.Parse(listBox1.SelectedItem.ToString().Substring(11, 1));
                    this.grafico.GetEscenario().getListaDeObjetos()[posicionDelObjeto].traslacion(30, 30);
                    break;

                case 13:
                    int posicionDelObjeto1 = int.Parse(listBox1.SelectedItem.ToString().Substring(11, 1));
                    int posicionDelPoligono = int.Parse(listBox1.SelectedItem.ToString().Substring(12, 1));
                    this.grafico.GetEscenario().getListaDeObjetos()[posicionDelObjeto1].getListaDePoligonos()[posicionDelPoligono].traslacion(30, 30);
                    break;
            }
            this.paint.drawEscenario(this.grafico.GetEscenario());
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paint.clear();
            int longitud = listBox2.SelectedItem.ToString().Length;
            switch (longitud)
            {
                case 9:
                    this.grafico.GetEscenario().rotacion(90);
                    break;

                case 12:
                    int posicionDelObjeto = int.Parse(listBox2.SelectedItem.ToString().Substring(11, 1));
                    this.grafico.GetEscenario().getListaDeObjetos()[posicionDelObjeto].rotacion(90);
                    break;

                case 13:
                    int posicionDelObjeto1 = int.Parse(listBox2.SelectedItem.ToString().Substring(11, 1));
                    int posicionDelPoligono = int.Parse(listBox2.SelectedItem.ToString().Substring(12, 1));
                    this.grafico.GetEscenario().getListaDeObjetos()[posicionDelObjeto1].getListaDePoligonos()[posicionDelPoligono].rotacion(90);
                    break;
            }
            this.paint.drawEscenario(this.grafico.GetEscenario());
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paint.clear();
            int longitud = listBox3.SelectedItem.ToString().Length;
            switch (longitud)
            {
                case 9:
                    this.grafico.GetEscenario().escalacion(2, 1);
                    break;

                case 12:
                    int posicionDelObjeto = int.Parse(listBox3.SelectedItem.ToString().Substring(11, 1));
                    this.grafico.GetEscenario().getListaDeObjetos()[posicionDelObjeto].escalacion(2, 1);
                    break;

                case 13:
                    int posicionDelObjeto1 = int.Parse(listBox3.SelectedItem.ToString().Substring(11, 1));
                    int posicionDelPoligono = int.Parse(listBox3.SelectedItem.ToString().Substring(12, 1));
                    this.grafico.GetEscenario().getListaDeObjetos()[posicionDelObjeto1].getListaDePoligonos()[posicionDelPoligono].escalacion(2, 1);
                    break;
            }
            this.paint.drawEscenario(this.grafico.GetEscenario());
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grafico.GetEscenario().cambiar_A_Absoluto();
            this.grafico.guardarGrafico();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.paint.clear();
            this.grafico = new Grafico();
            this.grafico.abrirGrafico();
            this.paint.drawEscenario(this.grafico.GetEscenario());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < 65)
            {
                animacion.avanzarArriba(grafico, paint);
            }
            if (contador >= 65 && contador < 100)
            {
                animacion.avanzarYgirar(grafico, paint);
            }
            if (contador >= 100 && contador < 120)
            {
                animacion.avanzarYgirarMasLento(grafico, paint);
            }
            if (contador >=120 && contador < 155)
            {
                animacion.avanzarYgirarMasLento(grafico, paint);
            }
            if (contador >= 155)
            {
                animacion.avanzarIzquierda(grafico, paint);
            }
            contador++;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            this.contador = 0;
        }


    }
}
