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
    public partial class MainForm : Form
    {
        private AuxiliaryForm form;

        public MainForm()
        {
            InitializeComponent();
            //Text = "Главное окно";
            
            form = new AuxiliaryForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ContainerForm().Show();
        }
    }
}
