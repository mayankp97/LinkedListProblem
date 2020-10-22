using NUnit.Framework;
using System;
using System.Text;
using LinkedListProblem;

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
    }
}
