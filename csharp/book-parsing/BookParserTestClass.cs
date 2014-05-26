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
		public void PrimeNumberOne (){
			Assert.IsFalse (BookParser.PrimeNumber (1));
		}

		[Test ()]
		public void PrimeNumberTwo (){
			Assert.IsTrue (BookParser.PrimeNumber (2));
		}

		[Test ()]
		public void PrimeNumberThree (){
			Assert.IsTrue (BookParser.PrimeNumber (3));
		}

		[Test ()]
		public void PrimeNumberFour (){
			Assert.IsFalse (BookParser.PrimeNumber (4));
		}

		[Test ()]
		public void PrimeNumberNineEightThree (){
			Assert.IsTrue (BookParser.PrimeNumber (983));
		}

		[Test ()]
		public void PrimeNumberNineEightFour (){
			Assert.IsFalse (BookParser.PrimeNumber (984));
		}
	}
}

