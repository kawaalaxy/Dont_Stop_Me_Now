using System;
using System.IO;

namespace Exercise1
{
	internal static class PrintFile
	{
		/// <summary>
		///   EXERCISE 1.1:
		///   <para />
		///   Read all the text in a file and print it in the console.
		/// </summary>
		/// <param name="path">the path (absolute or relative) to the file</param>
		
		public static void PrintAllFile(string path)
		{
			if (!File.Exists(path))
				 Console.WriteLine("could not open file:" + path);
			Console.WriteLine(File.ReadAllText(path));
		}

		/// <summary>
		///   EXERCISE 1.2:
		///   <para />
		///   Read only one line out of two and print it in the console.
		/// </summary>
		/// <param name="path"></param>
		public static void PrintHalfFile(string path)
		{
			if (!File.Exists(path))
				throw new Exception("could not open file:" + File.GetAttributes(path));
			
			string[] str_list = File.ReadAllLines(path);
			
			for (int i = 0; i < str_list.Length; i += 2)
			{
				Console.WriteLine(str_list[i]);
			}
		}
	}
}