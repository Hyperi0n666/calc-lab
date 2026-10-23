using System;

namespace CalcLab
{
    public partial class Calculator
    {
        /// <summary>Ввод B</summary>
        public void ReadB()
        {
                    Console.Write("B = ");
        _b = double.Parse(Console.ReadLine().Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
