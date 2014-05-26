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

		[Test ()]
		public void Occurences (){
			string book = BookParser.LoadBook("../../../../text.txt");
			var split = BookParser.SplitBook (book);
			var occurences = BookParser.Occurences (split);
			Assert.AreEqual (3437, occurences["The"]);
		}

		[Test ()]
		public void PrimeNumber (){
			Assert.IsTrue (BookParser.PrimeNumber (2));
			Assert.IsTrue (BookParser.PrimeNumber (3));
			Assert.IsFalse (BookParser.PrimeNumber (4));
			Assert.IsTrue (BookParser.PrimeNumber (983));
			Assert.IsFalse (BookParser.PrimeNumber (984));
		}
	}
}

