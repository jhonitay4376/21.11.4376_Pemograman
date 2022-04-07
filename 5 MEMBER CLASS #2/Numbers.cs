using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1 , int number2)
        {

            if (number1 < number2)
            { return number1; }
            else
            { return number2; }
        }

        public int FindMinimum(int number1 , int number2 , float number3)
        {
            if ((number1 < number2) && (number1 < number3))
            {
                return number1;
            }
            else if ((number2 < number1) && (number2 < number3))
            {
                return number2;
            }
            else
            {
                int x = Convert.ToInt32(number3);
                return x;
            }
        }

        public int FindMaximum(int number1 , int number2)
        {
            if (number1 > number2)
            { return number1; }
            else
            { return number2; }
           
        }

        public int FindMaximum(int number1 , int number2 , float number3)
        {
            if ((number1 > number2)&&(number1 > number3))
            {
                return number1;
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                return number2;
            }
            else
            {
                int x = Convert.ToInt32(number3);
                return x;
            }
            
        }
    }
}
