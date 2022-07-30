using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calc
    {
        double ac1 = 0;
        double ac2 = 0;
        string op = "+";
        string txtpanel = "0";
        bool is_lock_op = true;
        public double Sum()
        {
            return set_op("+");
        }
        private double set_op(string operation)
        {
            if (is_lock_op)
                return ac1;
            ac1 = Result();
            op = operation;
            is_lock_op = true;
            return ac1;
        }
        public double Sub()
        {
            return set_op("-");
        }
        public double Mult()
        {
            return set_op("*");
        }
        public double Result()
        {
            double re = 0;
            switch(op) 
            {
                case "+":
                    re = ac1 + ac2;
                    break;
                case "-":
                    re = ac1 - ac2;
                    break;
                case "*":
                    re = ac1 * ac2;
                    break;
                case "/":
                    re = ac1 / ac2;
                    break;
            }
            Clear();
            return re;
        }
        public void Clear()
        {
            op = "";
            ac1 = 0;
            ac2 = 0;
            txtpanel = "0";
        }
        public void Input(string n)
        {
            if (n == "," && txtpanel.Contains(","))
                return;
            is_lock_op = false;
            txtpanel += n;
            ac2 = double.Parse(txtpanel);
        }
    }
}
