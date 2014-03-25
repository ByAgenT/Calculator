using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Stack;

namespace Calculator
{
    public class Calculator
    {
        public double Calculate(String expression)
        {
            string[] str = ReversePolishNotation.ConvertToReversePolishNotation(ReversePolishNotation.DeleteSpaces(expression));
            var stack = new MyStack<double>();
            foreach (var s in str)
            {
                double number;
                if (Double.TryParse(s, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    double num1;
                    double num2;
                    switch (s)
                    {
                        case "+":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num1 + num2);
                            break;
                        case "-":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num1 - num2);
                            break;
                        case "*":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num1 * num2);
                            break;
                        case "/":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            stack.Push(num2 / num1);
                            break;
                            

                    }
                }
            }
            return stack.Pop();
        }
    }
}
