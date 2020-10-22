using NUnit.Framework;
using System;
using System.Text;
using LinkedListProblem;
using System.Reflection.PortableExecutable;

namespace LinkedListProblemTests
{
    [TestFixture]
    class LinkedListTest
    {
        [Test]
        public void Search_IfNodePresent_ReturnsTheNode()
        {
            var linkedList = new LinkedList();
            linkedList.AddAtBack(56);
            linkedList.AddAtBack(30);
            linkedList.AddAtBack(70);

            var result = linkedList.Search(30);

            Assert.That(result.data, Is.EqualTo(30));
        }

        [Test]
        public void Search_IfNodeAbsent_ReturnsNull()
        {
            var linkedList = new LinkedList();
            linkedList.AddAtBack(56);
            linkedList.AddAtBack(70);

            var result = linkedList.Search(30);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void InsertAfterElement_IfElementPresent_InsertsData()
        {
            var linkedList = new LinkedList();
            linkedList.AddAtBack(56);
            linkedList.AddAtBack(30);
            linkedList.AddAtBack(70);
            linkedList.InsertAfterElement(30, 77);

            var resultNode = linkedList.Search(77);

            Assert.That(resultNode.data, Is.EqualTo(77));
        }

        [Test]
        public void InsertAfterElement_IfElementAbsent_DoesNotInsertData()
        {
            var linkedList = new LinkedList();
            linkedList.AddAtBack(56);
            linkedList.AddAtBack(70);
            linkedList.InsertAfterElement(30, 77);

            var resultNode = linkedList.Search(77);

            Assert.That(resultNode, Is.Null);
        }
    }
}
