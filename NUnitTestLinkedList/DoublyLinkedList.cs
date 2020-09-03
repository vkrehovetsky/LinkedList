using LinkedListApp;
using NUnit.Framework;
using System.Text;

namespace Tests
{
    public class TestDoublyLinkedList
    {
        private DoublyLinkedList _doublyLinkedList;

        [SetUp]
        public void Setup()
        {
            _doublyLinkedList = new DoublyLinkedList();
        }

        [Test]
        public void Test_DoublyLinkedList_Add()
        {
            // Arrange
            string str = "C";
            StringBuilder stringBuilder = new StringBuilder("ABC");


            // Act
            _doublyLinkedList.Add("A");
            _doublyLinkedList.Add("B");
            var link = _doublyLinkedList.Add(str);

            // Assert
            Assert.AreEqual(str, link.Name);
            Assert.AreEqual(stringBuilder.ToString(), _doublyLinkedList.ToString());
        }

        [Test]
        public void Test_DoublyLinkedList_AddAfter()
        {
            // Arrange
            StringBuilder stringBuilder = new StringBuilder("ABB1C");

            // Act
            _doublyLinkedList.Add("A");
            var linkB = _doublyLinkedList.Add("B");
            _doublyLinkedList.Add("C");
            _doublyLinkedList.AddAfter(linkB, "B1");

            // Assert
            Assert.AreEqual(stringBuilder.ToString(), _doublyLinkedList.ToString());
        }

        [Test]
        public void Test_DoublyLinkedList_Remove()
        {
            // Arrange
            string str = "C";
            StringBuilder stringBuilder = new StringBuilder("AB");

            // Act
            _doublyLinkedList.Add("A");
            _doublyLinkedList.Add("B");
            _doublyLinkedList.Add(str);
            var link = _doublyLinkedList.Delete();

            // Assert
            Assert.AreEqual(str, link.Name);
            Assert.AreEqual(stringBuilder.ToString(), _doublyLinkedList.ToString());
        }

        [Test]
        public void Test_DoublyLinkedList_Contains()
        {
            // Arrange
            string str = "A";

            // Act
            _doublyLinkedList.Add(str);
            var isExist = _doublyLinkedList.Contains(str);

            // Assert
            Assert.AreEqual(true, isExist);
        }
    }
}