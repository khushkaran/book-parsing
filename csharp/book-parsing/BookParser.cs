using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace bookparsing
{
	public class BookParser
	{
		public static void Main(){
			string book = LoadBook ("../../../../text.txt");
			Array splitbook = SplitBook(book);
			foreach (string value in splitbook)
			{
				Console.WriteLine(value);
			}
		}

		public static string LoadBook(string filepath){
			StreamReader streamReader = new StreamReader(filepath);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			return text;
		}

		public static Array SplitBook(string book){
			string cleanedBook = Regex.Replace(book, "[^\\w\\-\\s]", "");
			var words = cleanedBook.Split(' ');
			return words;
		}
	}
}

