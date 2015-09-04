using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedQueue.Tests
{
    [TestClass]
    public class UnitTestsLinkedQueue
    {
        [TestMethod]
        public void PushPopElement_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<int>();
            Assert.AreEqual(0, stack.Count);

            stack.Enqueue(1);
            Assert.AreEqual(1, stack.Count);

            var element = stack.Dequeue();
            Assert.AreEqual(1, element);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void PushPop1000Elements_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<string>();
            Assert.AreEqual(0, stack.Count);

            for (int i = 0; i < 1000; i++)
            {
                stack.Enqueue(i + "");
                Assert.AreEqual(i + 1, stack.Count);
            }

            for (int i = 0; i < 1000; i++)
            {
                var element = stack.Dequeue();
                Assert.AreEqual(i + "", element);
                Assert.AreEqual(1000 - i - 1, stack.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopFromEmptyStack_ThrowsException()
        {
            var stack = new LinkedQueue<int>();
            stack.Dequeue();
        }

        [TestMethod]
        public void ToArray_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<int>();
            stack.Enqueue(3);
            stack.Enqueue(5);
            stack.Enqueue(-2);
            stack.Enqueue(7);

            var arr = stack.ToArray();
            var str = string.Join(" ", arr);
            Assert.AreEqual("3 5 -2 7", str);
        }

        [TestMethod]
        public void EmptyStackToArray_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<DateTime>();
            var arr = stack.ToArray();
            Assert.AreEqual(0, arr.Length);
        }
    }
}