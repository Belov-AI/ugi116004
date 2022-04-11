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
    public partial class AuxiliaryForm : Form
    {
        public AuxiliaryForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            //Visible = false;
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            var question = new DialogForm();

            var result = question.ShowDialog();

            if (result == DialogResult.OK)
                MessageBox.Show("Добро пожаловать в клуб!");
            else if(result == DialogResult.No)
                MessageBox.Show("Вы просто не умеете их готовить.");
        }

        private void openButon_Click(object sender, EventArgs e)
        {
            var form = new OwnedForm();
            //form.Owner = this;
            AddOwnedForm(form);
            form.Show();
        }
    }
}
