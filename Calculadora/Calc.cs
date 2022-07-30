
namespace Calculadora
{
    public class Calc
    {
        double ac1 = 0;
        double ac2 = 0;
        public double Ac2 { get => ac2; }
        public double Ac1 { get => ac1; }
        public string Op { get => op; }
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
            txtpanel = "";
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
        public double Div()
        {
            return set_op("/");
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
            ac1 = re;
            return re;
        }
        public void Clear()
        {
            op = "+";
            ac1 = 0;
            ac2 = 0;
            txtpanel = "0";
        }
        public void Input(string n)
        {
            is_lock_op = false;
            txtpanel += n;
            ac2 = double.Parse(txtpanel);
        }
    }
}
