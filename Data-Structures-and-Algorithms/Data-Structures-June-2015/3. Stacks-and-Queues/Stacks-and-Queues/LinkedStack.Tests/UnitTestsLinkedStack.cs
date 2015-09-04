using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedStack.Tests
{
    [TestClass]
    public class UnitTestsLinkedStack
    {
        [TestMethod]
        public void PushPopElement_ShouldWorkCorrectly()
        {
            var stack = new LinkedStack<int>();
            Assert.AreEqual(0, stack.Count);

            stack.Push(1);
            Assert.AreEqual(1, stack.Count);

            var element = stack.Pop();
            Assert.AreEqual(1, element);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void PushPop1000Elements_ShouldWorkCorrectly()
        {
            var stack = new LinkedStack<string>();
            Assert.AreEqual(0, stack.Count);

            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i + "");
                Assert.AreEqual(i + 1, stack.Count);
            }

            for (int i = 1000; i > 0; i--)
            {
                var element = stack.Pop();
                Assert.AreEqual((i - 1) + "", element);
                Assert.AreEqual(i - 1, stack.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopFromEmptyStack_ThrowsException()
        {
            var stack = new LinkedStack<int>();
            stack.Pop();
        }

        [TestMethod]
        public void ToArray_ShouldWorkCorrectly()
        {
            var stack = new LinkedStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(-2);
            stack.Push(7);

            var arr = stack.ToArray();
            var str = string.Join(" ", arr);
            Assert.AreEqual("7 -2 5 3", str);
        }

        [TestMethod]
        public void EmptyStackToArray_ShouldWorkCorrectly()
        {
            var stack = new LinkedStack<DateTime>();
            var arr = stack.ToArray();
            Assert.AreEqual(0, arr.Length);
        }
    }
}