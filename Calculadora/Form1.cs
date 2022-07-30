using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class txt : Form
    {
        Calc calculator;
        bool is_result = false;
        public txt()
        {
            calculator = new Calc();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            acomulator.Text += "/";
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            acomulator.Text += txtpanel.Text + "=";
            txtpanel.Text = calculator.Result().ToString();
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

        private void SetInp(string n)
        {
            if (is_result)
                txtpanel.Text = "";
            txtpanel.Text += n;
            calculator.Input(n);
            is_result = false;
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
            txtpanel.Text="";
            calculator.Clear();
        }

        private void operation_handler(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

    }
}
