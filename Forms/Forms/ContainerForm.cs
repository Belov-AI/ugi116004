using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ContainerForm : Form
    {
        int documentNumber = 0;

        public ContainerForm()
        {
            InitializeComponent();
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var document = new DocumentForm();
            document.MdiParent = this;
            documentNumber++;
            document.Text = "Документ " + documentNumber;
            document.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
