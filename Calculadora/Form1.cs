using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class txt : Form
    {
        Calc calculator;
        bool is_result = false;
        bool for_clean = true;
        public txt()
        {
            calculator = new Calc();
            InitializeComponent();
        }

        private void Inp1(object sender, EventArgs e)
        {
            SetInp("1");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            make_op(calculator.Sub().ToString(), "-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            make_op(calculator.Div().ToString(), "/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            make_op(calculator.Mult().ToString(), "*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            make_op(calculator.Sum().ToString(), "+");
        }

        private void make_op(string result, string operation)
        {
            is_result = true;
            acomulator.Text = result + operation;
            txtpanel.Text = result;
            for_clean = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            acomulator.Text =calculator.Ac1 + calculator.Op + calculator.Ac2 + "=";
            txtpanel.Text = calculator.Result().ToString();
            for_clean = true;
        }

        private void InpVirg(object sender, EventArgs e)
        {
            SetInp(",");
        }

        private void Inp0(object sender, EventArgs e)
        {
            SetInp("0");
        }

        private void Inp9(object sender, EventArgs e)
        {
            SetInp("9");
        }

        private void Inp8(object sender, EventArgs e)
        {
            SetInp("8");
        }

        private void Inp7(object sender, EventArgs e)
        {
            SetInp("7");
        }

        private void Inp6(object sender, EventArgs e)
        {
            SetInp("6");
        }

        private void Inp5(object sender, EventArgs e)
        {
            SetInp("5");
        }

        private void Clear()
        {
            acomulator.Text = "";
            txtpanel.Text = "";
            calculator.Clear();
        }

        private void SetInp(string n)
        {
            if(for_clean == true)
            {
                Clear();
            }

            if (is_result)
                txtpanel.Text = "";

            if (n == "," && txtpanel.Text.Contains(","))
                return;

            txtpanel.Text += n;
            calculator.Input(n);
            is_result = false;
            for_clean = false;
        }

        private void Inp4(object sender, EventArgs e)
        {
            SetInp("4");
        }

        private void Inp3(object sender, EventArgs e)
        {
            SetInp("3");
        }

        private void Inp2(object sender, EventArgs e)
        {
            SetInp("2");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void operation_handler(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

    }
}
