using System;

namespace CalcLab
{
    public partial class Calculator
    {
        /// <summary>деление</summary>
        public void Div()
        {
                    if (_b == 0)
        {
            Console.WriteLine("Деление на ноль невозможно");
            return;
        }
        Console.WriteLine("{0} / {1} = {2}", _a, _b, _a / _b);
        }
    }
}
