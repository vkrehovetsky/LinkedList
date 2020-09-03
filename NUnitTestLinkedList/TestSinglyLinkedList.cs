using LinkedListApp;
using NUnit.Framework;
using System.Text;

namespace NUnitTestLinkedList
{
    public class TestSinglyLinkedList
    {
        private SinglyLinkedList _singlyLinkedList;

        [SetUp]
        public void Setup()
        {
            _singlyLinkedList = new SinglyLinkedList();
        }

        [Test]
        public void Test_SinglyLinkedList_Add()
        {
            // Arrange
            string str = "C";
            StringBuilder stringBuilder = new StringBuilder("ABC");


            // Act
            _singlyLinkedList.Add("A");
            _singlyLinkedList.Add("B");
            var link = _singlyLinkedList.Add(str);

            // Assert
            Assert.AreEqual(str, link.Name);
            Assert.AreEqual(stringBuilder.ToString(), _singlyLinkedList.ToString());
        }

        [Test]
        public void Test_SinglyLinkedList_Remove()
        {
            // Arrange
            string str = "C";
            StringBuilder stringBuilder = new StringBuilder("AB");

            // Act
            _singlyLinkedList.Add("A");
            _singlyLinkedList.Add("B");
            _singlyLinkedList.Add(str);
            var link = _singlyLinkedList.Delete();

            // Assert
            Assert.AreEqual(str, link.Name);
            Assert.AreEqual(stringBuilder.ToString(), _singlyLinkedList.ToString());
        }

        [Test]
        public void Test_SinglyLinkedList_Contains()
        {
            // Arrange
            string str = "A";

            // Act
            _singlyLinkedList.Add(str);
            var isExist = _singlyLinkedList.Contains(str);

            // Assert
            Assert.AreEqual(true, isExist);
        }
    }
}
