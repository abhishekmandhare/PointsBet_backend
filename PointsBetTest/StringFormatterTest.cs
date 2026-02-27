using PointsBet.Backend.OnlineCodeTest;

namespace PointsBet
{
    [TestClass]
    public class StringFormatterTest
    {
        [TestMethod]
        [DataRow("`1`, `2`, `3`", new string[] { "1", "2", "3" }, "`")]
        [DataRow("1, 2, 3", new string[] { "1", "2", "3" }, null)]
        [DataRow(@"""1"", ""2"", ""3""", new string[] { "1", "2", "3" }, @"""")]
        [DataRow("", new string[] { }, "`")]
        [DataRow("1", new String[] { "1" }, "")]
        [DataRow("1, 2", new string[] { "1", null!, "2" }, "")]
        [DataRow("", new string[] { null!, null!, null! }, "")]
        [DataRow("!2!, !3!", new string[] { " ", "2", "3" }, "!")]
        [DataRow("!1!", new string[] { "1", "", "" }, "!")]
        public void ToCommaSeparatedListTest(string expected, string[] listInput, string quoteInput)
        {
            var actual = StringFormatter.ToCommaSeparatedList(listInput, quoteInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToCommaSeparatedListTest_NullItems_ThrowsException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => StringFormatter.ToCommaSeparatedList(null!, "!"));

            Assert.AreEqual("items", exception.ParamName);
        }

    }
}
