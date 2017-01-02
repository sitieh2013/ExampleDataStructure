using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructuresExample;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        ManagerNodeSimple<int> manager = new ManagerNodeSimple<int>();

        [TestMethod]
        public void TestCola()
        {
            MyQueue<int> myQueue = new MyQueue<int>(manager);

            for (int i = 1; i < 100; i++)
            {
                myQueue.Enqueue(i);
            }

            Assert.AreEqual(1, myQueue.Peek);
            //myQueue.Dequeue();
            //Assert.AreEqual(2, myQueue.Peek);
        }
        [TestMethod]
        public void TestColaSystem()
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i < 100; i++)
            {
                queue.Enqueue(i);
            }

            Assert.AreEqual(1, queue.Peek());
            //queue.Dequeue();
            //Assert.AreEqual(2, queue.Peek());
        }

        [TestMethod]
        public void TestPila()
        {
            MyStack<int> myStack = new MyStack<int>(manager);

            for (int i = 1; i < 100; i++)
            {
                myStack.Push(i);
            }

            Assert.AreEqual(99, myStack.Peek);
            //myStack.Pop();
            //Assert.AreEqual(98, myStack.Peek);
        }

        [TestMethod]
        public void TestPilaSystem()
        {
            Stack<int> myStack = new Stack<int>();

            for (int i = 1; i < 100; i++)
            {
                myStack.Push(i);
            }

            Assert.AreEqual(99, myStack.Peek());
            //myStack.Pop();
            //Assert.AreEqual(98, myStack.Peek());
        }

        [TestMethod]
        public void TestLista()
        {
           MyList<int> myList = new MyList<int>(manager);

            for (int i = 1; i < 100; i++)
            {
                myList.Add(i);
            }

            Assert.AreEqual(1, myList[0]);
            //myList.RemoveAt(myList.Count - 1);
            //Assert.AreEqual(98, myList[myList.Count - 1]);
        }

        [TestMethod]
        public void TestListaSystem()
        {
            List<int> systemList = new List<int>();

            for (int i = 1; i < 100; i++)
            {
                systemList.Add(i);
            }

            Assert.AreEqual(1, systemList[0]);
            //systemList.RemoveAt(systemList.Count - 1);
            //Assert.AreEqual(98, systemList[systemList.Count - 1]);
        }
    }
}
