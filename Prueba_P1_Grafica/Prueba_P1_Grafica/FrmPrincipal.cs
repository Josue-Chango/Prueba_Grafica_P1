using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_P1_Grafica
{
    public partial class FrmPrincipal : Form
    {
        float radioCirculo1 = 150;
        //float radioCirculo2 = 75;
        int x1 = 220, y1 = 20;
        //int x2 = 295, y2 = 95;
        bool dibujar = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pctGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;
            float cx = x1 + radioCirculo1;
            float cy = y1 + radioCirculo1;
            float radioCirculo2 = 75;
            float radioCirculo3 = 95;
            int x2 = (int)(cx - radioCirculo2);
            int y2 = (int)(cy - radioCirculo2);
            int x3 = (int)(cx - radioCirculo3);
            int y3 = (int)(cy - radioCirculo3);

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();
            figuras.GraficarCirculo(g, x1, y1, radioCirculo1);
            figuras.GraficarDecagono(g, x1, y1, radioCirculo1, false);
            figuras.GraficarPentagono(g, x1, y1, radioCirculo1, 1, Color.OrangeRed, false);
            figuras.GraficarPentagono(g, x1, y1, radioCirculo1, 2, Color.OrangeRed, false);
            figuras.GraficarEstrella7P(g, x1, y1, radioCirculo1, 1, Color.Orange);
            figuras.GraficarEstrella5P(g, x1, y1, radioCirculo1, 1, Color.DarkBlue);
            figuras.GraficarEstrella5P(g, x1, y1, radioCirculo1, 2, Color.DarkBlue);
            figuras.GraficarDiagonales(g, x1, y1, radioCirculo1);

            
            figuras.GraficarPentagono(g, x3, y3, radioCirculo3, 1, Color.DarkGreen, true);
            figuras.GraficarPentagono(g, x3, y3, radioCirculo3, 2, Color.DarkGreen, true);
            figuras.GraficarEstrella7P(g, x2, y2, radioCirculo2, 1, Color.Orange);
            figuras.GraficarEstrella5P(g, x2, y2, radioCirculo2, 1, Color.Blue);
            figuras.GraficarDiagonales(g, x2, y2, radioCirculo2);
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            /*if (float.TryParse(txtRadio.Text, out radioCirculo))
            {*/
                dibujar = true;
                pctGrafico.Invalidate(); // Redibuja solo el PictureBox
           /* }
            else
            {
                MessageBox.Show("Ingresa un número válido para el radio.");
            }*/
        }

        }
    }

