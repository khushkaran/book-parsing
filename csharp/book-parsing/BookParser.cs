using System;
using System.IO;

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
	}
}

