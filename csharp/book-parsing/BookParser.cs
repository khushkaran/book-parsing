﻿using System;
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
			var text = LoadBook ("../../../../text.txt");
			Console.WriteLine (BookParser.ProduceReport (text));
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
				occurences.AddOrUpdate (UpdateWord(word), 1, (s, i) => i + 1);
			}
			return occurences;
		}

		public static string ProduceReport(string text){
			string report = "Word  |  Number of Words  |  Prime?\n";
			var data = Occurences(SplitBook(text));
			foreach(KeyValuePair<string, int> entry in data){
				report += string.Format("{0}  |  {1}  |  {2}\n", entry.Key, entry.Value, PrimeNumber(entry.Value));
			}
			report = report.Remove(report.Length - 1);
			return report;
		}

		public static bool PrimeNumber(int n){
			if(n == 1){ return false; }
			for (int i = 2; i <= n; i++) {
				if (n % i == 0 && i != n) {
					return false;
				}
			}
			return true;
		}

		static string UpdateWord(string s){
			if (string.IsNullOrEmpty(s)){
				return string.Empty;
			}
			s = s.ToLower ();
			return char.ToUpper(s[0]) + s.Substring(1);
		}
	}
}

