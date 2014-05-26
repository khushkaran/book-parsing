using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace bookparsing
{
	public class BookParser
	{
		public static void Main(){
		}

		public static string LoadBook(string filepath){
			StreamReader streamReader = new StreamReader(filepath);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			return text;
		}

		public static Array SplitBook(string book){
			string[] words = Regex.Split (book, @"[^\w\s]");
			return words;
		}
	}
}

