using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;

namespace bookparsing
{
	public class BookParser
	{
		public static void Main(){
			string book = LoadBook ("../../../../text.txt");
			Array splitbook = SplitBook(book);
			ConcurrentDictionary<string, int> occurences = Occurences (splitbook);
//			foreach (string value in splitbook){
//				Console.WriteLine(value);
//			}
			foreach(KeyValuePair<string, int> entry in occurences)
			{
				Console.WriteLine(entry);
			}
			Console.WriteLine (occurences ["The"]);
		}

		public static string LoadBook(string filepath){
			StreamReader streamReader = new StreamReader(filepath);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			return text;
		}

		public static Array SplitBook(string book){
			string cleanedBook = Regex.Replace(book, "[^\\w\\-\\s]", String.Empty);
			cleanedBook = Regex.Replace(cleanedBook, "--", " ");
			cleanedBook = Regex.Replace(cleanedBook, "\n", " ");
			cleanedBook = Regex.Replace(cleanedBook, "\r", String.Empty);
			var words = cleanedBook.Split(' ');
			words = words.Where (val => val != "").ToArray ();
			return words;
		}

		public static ConcurrentDictionary<string, int> Occurences(Array words){
			ConcurrentDictionary<string, int> occurences = new ConcurrentDictionary<string, int>();
			foreach (string word in words){
				string lowercaseWord = word.ToLower();
				occurences.AddOrUpdate (UppercaseFirst(lowercaseWord), 1, (s, i) => i + 1);
			}
			return occurences;
		}

		static string UppercaseFirst(string s){
			if (string.IsNullOrEmpty(s)){
				return string.Empty;
			}
			return char.ToUpper(s[0]) + s.Substring(1);
		}
	}
}

