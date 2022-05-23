using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Controls
{
    public partial class MainForm : Form
    {
        int pictureNumber;

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

            pictureNumber = 7;
            LoadPicture();

            textOpenFileDialog.Filter = "Простой текст|*.txt|Форматированный текст|*.rtf";
            textOpenFileDialog.InitialDirectory = Application.StartupPath;
        }

        private void LoadPicture()
        {
            var pic = Application.StartupPath + @"\Images\pic" + pictureNumber.ToString() + ".jpg";
            myPictureBox.Load(pic);
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

        private void ChangePicture(object sender, EventArgs e)
        {
            var button = sender as Button;
            myProgressBar.Step = 25;

            if (button.Text == "<<")
                pictureNumber--;
            else
                pictureNumber++;

            if (pictureNumber == 8)
                pictureNumber = 1;
            else if (pictureNumber == 0)
                pictureNumber = 7;

            LoadPicture();
            myProgressBar.Value = (pictureNumber - 1) * myProgressBar.Step;
        }

        private void slideshowTimer_Tick(object sender, EventArgs e)
        {
            myProgressBar.PerformStep();

            if(myProgressBar.Value % 25 == 0)
            {
                pictureNumber++;
                LoadPicture();
            }

            if (pictureNumber == 7)
                slideshowTimer.Enabled = false;               
        }

        private void slideshowButton_Click(object sender, EventArgs e)
        {
            slideshowTimer.Enabled = true;
            pictureNumber = 1;
            myProgressBar.Value = 0;
            myProgressBar.Step = 1;
            LoadPicture();
        }

        private void loadRTFbutton_Click(object sender, EventArgs e)
        {
            if (textOpenFileDialog.ShowDialog() == DialogResult.OK)
                if (textOpenFileDialog.FilterIndex == 1)
                    richTextBox1.Text = File.ReadAllText(textOpenFileDialog.FileName, Encoding.Default);
                else
                    richTextBox1.LoadFile(textOpenFileDialog.FileName);
        }

        private void captionLabel_MouseHover(object sender, EventArgs e)
        {
            captionLabel.ForeColor = Color.Blue;
        }

        private void captionLabel_MouseLeave(object sender, EventArgs e)
        {
            captionLabel.ForeColor = Color.Black;
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && inputTextBox.Text != "")
                inputButton_Click(sender, e);
        }
    }
}
