﻿using System;
using System.Collections.Generic;
using System.Linq;
using Calculator.Stack;

namespace Calculator
{
    internal static class ReversePolishNotation
    {
        private static readonly string[] Operators = new string[] { "(", ")", "+", "*", "-", "/" };



        public static string DeleteSpaces(string input)
        {
            return input.Replace(" ", string.Empty);
        }


        public static int GetPriority(string element)
        {
            switch (element)
            {
                case "+":
                    return 2;
                case "-":
                    return 3;
                case "*":
                    return 4;
                case "/":
                    return 4;
                default:
                    return 6;
            }
        }

        public static string[] ConvertToReversePolishNotation(string input)
        {
            var output = new List<string>();
            var stack = new MyStack<string>();
            int startOfNum = 1;
            bool isNumStarted = false;
            int counter = 0;
            int lnth = 0;
            foreach (var i in input)
            {


                if (Char.IsDigit(i) && !isNumStarted)
                {
                    isNumStarted = true;
                    startOfNum = counter;
                    lnth++;
                }

                if (!Char.IsDigit(i) && isNumStarted)
                {
                    string number = input.Substring(startOfNum, lnth - 1);
                    output.Add(number);
                    isNumStarted = false;
                    lnth = 0;
                }

                if (Char.IsDigit(i) && isNumStarted)
                {
                    lnth++;
                }

                if (counter == input.Length - 1 && isNumStarted)
                {
                    string number = input.Substring(startOfNum, lnth - 1);
                    output.Add(number);
                    isNumStarted = false;
                    lnth = 0;
                }
                if (Operators.Contains(i.ToString()))
                {
                    if (i.ToString() == "(")
                    {
                        stack.Push(i.ToString());

                    }

                    if (i.ToString() == ")")
                    {

                        while (stack.Top.Object != "(")
                        {
                            output.Add(stack.Pop());
                            if (stack.Top == null) continue;
                        }
                    }

                    if (i.ToString() == "+" || i.ToString() == "/" || i.ToString() == "*" || i.ToString() == "-")
                    {
                        if (stack.Top != null)
                        {
                            if (GetPriority(i.ToString()) > GetPriority(stack.Top.Object))
                            {
                                /*output.Add(i.ToString());
                                output.Add(stack.Pop());*/
                                stack.Push(i.ToString());
                            }
                            else
                            {
                                stack.Push(i.ToString());
                            }


                        }
                        else
                        {
                            stack.Push(i.ToString());
                        }

                    }
                }
                if (counter == input.Length - 1)
                {
                    while (stack.Top != null)
                    {
                        if (stack.Top.Object == "(" || stack.Top.Object == ")")
                        {
                            stack.Pop();
                        }
                        else
                        {
                            output.Add(stack.Pop());
                        }

                    }
                }
                counter++;

            }
            return output.ToArray();
        }
    }
}
