using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_P1_Grafica
{
    internal class Figuras
    {

        public void GraficarCirculo(Graphics g,int x, int y, float radio)
        {

            Pen lapiz = new Pen(Color.Yellow, 2);

            int diametro = (int)(radio * 2);

            g.DrawEllipse(lapiz, x, y, diametro, diametro);
            g.FillEllipse(Brushes.Black, x, y, diametro, diametro);
            lapiz.Dispose();
        }
        public void GraficarDecagono(Graphics g, int x, int y, float radio, bool rotado)
        {
            Pen lapiz = new Pen(Color.Yellow, 2);

            int lados = 10;
            PointF[] puntos = new PointF[lados];

            float cx = x + radio;
            float cy = y + radio;

            double offsetAngulo = rotado ? (Math.PI / lados) : 0;

            for (int i = 0; i < lados; i++)
            {
                double angulo = (2 * Math.PI * i / lados) - (Math.PI / 2) + offsetAngulo;
                puntos[i] = new PointF(
                    cx + radio * (float)Math.Cos(angulo),
                    cy + radio * (float)Math.Sin(angulo)
                );
            }
            g.FillPolygon(Brushes.Purple, puntos);
            g.DrawPolygon(lapiz, puntos);
            lapiz.Dispose();
        }

        public void GraficarPentagono(Graphics g, int x, int y, float radio, int aux, Color color, bool rotado)
        {
            int indiceInicio = aux - 1;

            Pen lapiz = new Pen(Color.Yellow, 2);
            SolidBrush relleno = new SolidBrush(color);

            int lados = 10;
            PointF[] puntos = new PointF[5];

            float cx = x + radio;
            float cy = y + radio;
            double offsetAngulo = rotado ? (Math.PI / lados) : 0;

            for (int i = 0; i < 5; i++)
            {
                double angulo = (2 * Math.PI * (indiceInicio + i * 2) / lados) - (Math.PI / 2) + offsetAngulo;
                puntos[i] = new PointF(
                    cx + radio * (float)Math.Cos(angulo),
                    cy + radio * (float)Math.Sin(angulo)
                );
            }

            g.DrawPolygon(lapiz, puntos);
            g.FillPolygon(relleno, puntos);
            lapiz.Dispose();
        }

        public void GraficarEstrella7P(Graphics g, int x, int y, float radio, int verticeInicial, Color color)
        {
            int indiceInicio = verticeInicial - 1;

            Pen lapiz = new Pen(Color.Yellow, 2);
            SolidBrush relleno = new SolidBrush(color);
            int lados = 10;
            PointF[] puntos = new PointF[lados];

            float cx = x + radio;
            float cy = y + radio;

            for (int i = 0; i < lados; i++)
            {
                double angulo = (2 * Math.PI * (indiceInicio + i * 3) / lados) - (Math.PI / 2);
                puntos[i] = new PointF(
                    cx + radio * (float)Math.Cos(angulo),
                    cy + radio * (float)Math.Sin(angulo)
                );
            }

            g.FillPolygon(relleno, puntos, System.Drawing.Drawing2D.FillMode.Winding);
            g.DrawPolygon(lapiz, puntos);
            
            lapiz.Dispose();
        }

        public void GraficarEstrella5P(Graphics g, int x, int y, float radio, int verticeInicial, Color color)
        {
            int indiceInicio = verticeInicial - 1;

            Pen lapiz = new Pen(Color.Yellow, 2);
            SolidBrush relleno = new SolidBrush(color);

            int lados = 10;
            PointF[] puntos = new PointF[lados];

            float cx = x + radio;
            float cy = y + radio;

            for (int i = 0; i < lados; i++)
            {
                double angulo = (2 * Math.PI * (indiceInicio + i * 4) / lados) - (Math.PI / 2);
                puntos[i] = new PointF(
                    cx + radio * (float)Math.Cos(angulo),
                    cy + radio * (float)Math.Sin(angulo)
                );
            }

            g.FillPolygon(relleno, puntos, System.Drawing.Drawing2D.FillMode.Winding);
            g.DrawPolygon(lapiz, puntos);
            
            lapiz.Dispose();
        }

        public void GraficarDiagonales(Graphics g, int x, int y, float radio)
        {
            Pen lapiz = new Pen(Color.Yellow, 2);

            int lados = 10;
            PointF[] puntos = new PointF[lados];

            float cx = x + radio;
            float cy = y + radio;

            for (int i = 0; i < lados; i++)
            {
                double angulo = (2 * Math.PI * i / lados) - (Math.PI / 2);
                puntos[i] = new PointF(
                    cx + radio * (float)Math.Cos(angulo),
                    cy + radio * (float)Math.Sin(angulo)
                );
            }

            for (int i = 0; i < lados / 2; i++)
            {
                g.DrawLine(lapiz, puntos[i], puntos[i + 5]);
            }

            lapiz.Dispose();
        }
    }
}
