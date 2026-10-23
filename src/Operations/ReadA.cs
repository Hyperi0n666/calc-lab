using System;

namespace CalcLab
{
    public partial class Calculator
    {
        /// <summary>Ввод A</summary>
        public void ReadA()
        {
                    Console.Write("A = ");
        _a = double.Parse(Console.ReadLine().Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
