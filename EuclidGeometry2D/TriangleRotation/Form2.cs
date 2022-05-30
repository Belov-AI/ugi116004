using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using EuclidGeometry2D;

namespace TriangleRotation
{
    public partial class Form2 : Form
    {
        EuclidGeometry2D.Point center;
        Triangle originalTriangle;
        Triangle rotatedTriangle;
        Graphics g;

        double scale = 75;

        public Form2(
            EuclidGeometry2D.Point center, 
            Triangle originalTriangle,
            Triangle rotatedTriangle
            )
        {
            InitializeComponent();

            this.center = center;
            this.originalTriangle = originalTriangle;
            this.rotatedTriangle = rotatedTriangle;

            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        System.Drawing.Point ConvertToSctreen(EuclidGeometry2D.Point point)
        {
            return new System.Drawing.Point(
                (int)Math.Round(point.X * scale),
                (int)Math.Round(ClientSize.Height - point.Y * scale));
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            var cent = ConvertToSctreen(center);
            g.FillEllipse(Brushes.Red, cent.X - 3, cent.Y - 3, 5, 5);

            DrawTriangle(originalTriangle, Color.Blue, 5, DashStyle.Solid);
            DrawTriangle(rotatedTriangle, Color.Green, 5, DashStyle.Dot);
        }

        void DrawTriangle(Triangle t, Color color, int penWith, DashStyle dash)
        {
            using (var p = new Pen(color, penWith))
            {
                p.DashStyle = dash;
                g.DrawLines(p,
                    new[] {
                    ConvertToSctreen(t.A),
                    ConvertToSctreen(t.B),
                    ConvertToSctreen(t.C),
                    ConvertToSctreen(t.A),
                    });
            }
        }
    }
}
