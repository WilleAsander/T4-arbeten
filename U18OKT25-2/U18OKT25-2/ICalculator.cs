using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OKT25_2
{
    //Abstract, dvs övergripande funktion utan kod
    public interface ICalculator
    {
        decimal Add(decimal number1, decimal number2);
        decimal Sub(decimal number1, decimal number2);
        decimal Mul(decimal number1, decimal number2);
        decimal Div(decimal number1, decimal number2);
    }
}
