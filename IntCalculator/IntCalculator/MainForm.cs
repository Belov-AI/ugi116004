using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntCalculator
{
    public partial class MainForm : Form
    {
        Calculator calc;
        Dictionary<char, Func<int>> op;

        public MainForm()
        {
            InitializeComponent();

            calc = new Calculator();
            op = new Dictionary<char, Func<int>>();
            op['+'] = calc.GetSum;
            op['-'] = calc.GetDifference;
            op['*'] = calc.GetProduct;
            op['/'] = calc.GetQuotient;
            op['%'] = calc.GetRest;

            KeyPreview = true;
        }

        private void KeyOp(char keyChar)
        {
            opLabel.Text = keyChar.ToString();
            resultLabel.Text = "";

            if (xTextBox.Focused)
                yTextBox.Focus();
        }

        private void KeyResult()
        {
            if(!int.TryParse(xTextBox.Text, out calc.X) ||
                !int.TryParse(yTextBox.Text, out calc.Y) ||
                opLabel.Text == "" ||
                (opLabel.Text == "/" || opLabel.Text == "%") && calc.Y == 0)
            {
                resultLabel.Text = "Ошибка";
                return;
            }

            resultLabel.Text = op[char.Parse(opLabel.Text)]().ToString();
            resultLabel.Focus();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (op.ContainsKey(e.KeyChar))
                KeyOp(e.KeyChar);
            else if (e.KeyChar == '=')
                KeyResult();

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                xTextBox.Text = "";
                yTextBox.Text = "";
                opLabel.Text = "";
                resultLabel.Text = "";
                xTextBox.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
                KeyResult();
        }
    }
}
