using Calculator.Stack;
using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class MyStackTest
    {
        [TestCase]
        public void AddValueTypeItemToStack()
        {
            int value = 12345;

            MyStack<int> stack = new MyStack<int>();
            stack.Push(value);

            int result = stack.Pop();

            Assert.AreEqual(result, value, "Pop value is incorrect");
        }

        [TestCase]
        public void AddRefTypeItemToStack()
        {
            String value = "Hello World";

            MyStack<String> stack = new MyStack<String>();
            stack.Push(value);

            String result = stack.Pop();

            Assert.AreEqual(result, value, "Pop value is incorrect");
        }
    }
}
