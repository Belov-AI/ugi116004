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

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            using(var p = new Pen(Color.Red, 5))
            {
                g.DrawLine(p, 10, 10, 300, 300);
                
                p.DashStyle = DashStyle.Dash;
                p.Width = 3;
                p.Color = Color.Blue;
                g.DrawRectangle(p, 100, 100, 400, 200);

                p.Width = 7;
                p.Color = Color.Violet;
                p.DashStyle = DashStyle.Solid;
                g.DrawEllipse(p, 4, 4, ClientSize.Width - 8, ClientSize.Height - 8);
            }

            g.FillEllipse(Brushes.DarkGreen, 200, 25, 50, 50);
            
            using(var font = new Font("Calibri", 50, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                g.DrawString("Hello!", font, Brushes.Orange, 300, 150);
            }
        }
    }
}
