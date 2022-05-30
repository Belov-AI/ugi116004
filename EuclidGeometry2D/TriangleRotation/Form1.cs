using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuclidGeometry2D;

namespace TriangleRotation
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new EuclidGeometry2D.Point(
                double.Parse(aXTextBox.Text),
                double.Parse(aYTextBox.Text));

            var b = new EuclidGeometry2D.Point(
                double.Parse(bXTextBox.Text),
                double.Parse(bYTextBox.Text));

            var c = new EuclidGeometry2D.Point(
                double.Parse(cXTextBox.Text),
                double.Parse(cYTextBox.Text));

            var t = new Triangle(a, b, c);
            var rotated = t.Clone() as Triangle;
            rotated.Rotate(new EuclidGeometry2D.Point(
                double.Parse(centerXTextBox.Text),
                double.Parse(centerYTextBox.Text)),
                double.Parse(angleTextBox.Text));
            
            var center = new EuclidGeometry2D.Point(
                double.Parse(centerXTextBox.Text),
                double.Parse(centerYTextBox.Text));

            var picture = new Form2(center, t, rotated);
            picture.Show();

        }
    }
}
