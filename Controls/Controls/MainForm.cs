using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //var button = new Button();
            //button.Location = new Point(100, 200);
            //button.Text = "Click me";
            //Controls.Add(button);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                inputButton.Visible = true;
                inputLabel.Visible = false;
            }

            else
            {
                inputButton.Visible = false;
                inputLabel.Visible = true;
            }
                
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            captionLabel.Text = inputTextBox.Text;
            inputTextBox.Text = "";
        }

        private void ChangeFontStyle(object sender, EventArgs e)
        {
            var fontStyle = FontStyle.Regular;

            if (boldCheckBox.Checked)
                fontStyle |= FontStyle.Bold;

            if (italicCheckBox.Checked)
                fontStyle |= FontStyle.Italic;

            if (undelineCheckBox.Checked)
                fontStyle |= FontStyle.Underline;

            captionLabel.Font = new Font(
                captionLabel.Font.FontFamily,
                captionLabel.Font.Size,
                fontStyle);
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            var radiobutton = sender as RadioButton;
            int size = int.Parse(radiobutton.Text.Split()[0]);

            captionLabel.Font = new Font(
                captionLabel.Font.FontFamily,
                size,
                captionLabel.Font.Style);
        }
    }
}
