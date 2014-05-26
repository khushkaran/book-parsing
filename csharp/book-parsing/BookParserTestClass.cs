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
			Assert.AreEqual (61352, BookParser.SplitBook (LoadBook ("../../../../text.txt")).Count);
		}
	}
}

