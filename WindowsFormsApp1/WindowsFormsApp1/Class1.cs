using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CalcEngine
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }


}
