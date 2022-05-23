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

            stringListBox.Items.Add("Москва");
            stringListBox.Items.Add("Екатеринбург");
            stringListBox.Items.Add("Санкт-Питербург");
            stringListBox.Items.Add("Владивосток");

            fontComboBox.Items.Add("Microsoft San Serif");
            fontComboBox.Items.Add("Times New Roman");
            fontComboBox.Items.Add("Courier New");
            fontComboBox.Items.Add("Arial");
            fontComboBox.SelectedIndex = 0;
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

        private void stringListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            captionLabel.Text = stringListBox.SelectedItem.ToString();
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fontFamilyName = fontComboBox.SelectedItem.ToString();

            captionLabel.Font = new Font(
                fontFamilyName,
                captionLabel.Font.Size,
                captionLabel.Font.Style);
        }
    }
}
