using PiedraPapelTijera.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {

        public Random rd = new Random();
        private static int puntosJug = 0;
        private static int puntosMaq = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void jugar(String jugada)
        {
            int jugadaMaquinaInt = rd.Next(1, 99);
            if (jugadaMaquinaInt > 0 && jugadaMaquinaInt <= 33)
            {
                jugadaMaquinaInt = 1;
            } else if (jugadaMaquinaInt > 33 && jugadaMaquinaInt <= 66)
            {
                jugadaMaquinaInt = 2;
            } else if (jugadaMaquinaInt > 66 && jugadaMaquinaInt <=99)
            {
                jugadaMaquinaInt = 3;
            }
            String jugadaMaquina = "";

            switch(jugadaMaquinaInt)
            {
                case 1:
                      jugadaMaquina = "piedra";
                    pboxMaquina.Image = Resources.piedra;
                    break;
                case 2:
                      jugadaMaquina = "papel";
                    pboxMaquina.Image = Resources.papel;

                    break;
                case 3:
                      jugadaMaquina = "tijera";
                    pboxMaquina.Image = Resources.tijera;

                    break;
            }


            if (jugadaMaquina.Equals(jugada))
            {
                lblResultado.Text = "EMPATE";
                this.BackColor = Color.Yellow;
            } else
            {
                switch(jugada)
                {
                    case  "piedra":
                        if (jugadaMaquina.Equals("papel"))
                        {
                            lblResultado.Text = "DERROTA";
                            this.BackColor = Color.Red;
                            puntosMaq++;
                        } else
                        {
                            lblResultado.Text = "VICTORIA";
                            this.BackColor = Color.Green;
                            puntosJug++;
                        }
                    break;

                    case "papel":
                        if (jugadaMaquina.Equals("tijera"))
                        {
                            lblResultado.Text = "DERROTA";
                            this.BackColor = Color.Red;
                            puntosMaq++;

                        }
                        else
                        {
                            lblResultado.Text = "VICTORIA";
                            this.BackColor = Color.Green;
                            puntosJug++;

                        }
                        break;

                    case "tijera":
                        if (jugadaMaquina.Equals("piedra"))
                        {
                            lblResultado.Text = "DERROTA";
                            this.BackColor = Color.Red;
                            puntosMaq++;

                        }
                        else
                        {
                            lblResultado.Text = "VICTORIA";
                            this.BackColor = Color.Green;
                            puntosJug++;

                        }
                        break;
                }
            }
            lblPuntosMaq.Text = puntosMaq.ToString();
            lblPuntosJugador.Text = puntosJug.ToString();

            btnPapel.Enabled = false;
            btnPiedra.Enabled = false;
            btnTijera.Enabled = false;
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jugar("papel");
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            jugar("piedra");
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            jugar("tijera");
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            lblResultado.Text = "";

            pboxMaquina.Image = null;

            btnPapel.Enabled = true;
            btnPiedra.Enabled = true;
            btnTijera.Enabled = true;
        }
    }
}
