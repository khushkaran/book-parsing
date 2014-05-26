using NUnit.Framework;
using System;

namespace bookparsing
{
	[TestFixture ()]
	public class BookParserTestClass
	{
		[Test ()]
		public void LoadBook (){
			Assert.IsNotEmpty (BookParser.LoadBook("../../../../text.txt"));
		}

		[Test ()]
		public void SplitBook (){
			string book = BookParser.LoadBook("../../../../text.txt");
			var split = BookParser.SplitBook (book);
			Assert.AreEqual ("The", split.GetValue(0));
		}
	}
}

