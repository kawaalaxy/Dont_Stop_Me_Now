using System;
using System.Dynamic;
using System.IO;

namespace Exercise1
{
	internal static class CopyFile
	{
		/// <summary>
		///   EXERCISE 1.3:
		///   <para />
		///   Read the source file and put its content into destination file
		/// </summary>
		/// <param name="source">the path to the source file</param>
		/// <param name="destination">the path to the destination file</param>
		public static void CopyAllFile(string source, string destination)
		{
			if (!File.Exists(source))
				throw new Exception("could not open file:" + source);
			
			string txt = File.ReadAllText(source);
			
			File.Delete(destination);
			
			File.AppendAllText(destination,txt);

		}

		/// <summary>
		///   EXERCISE 1.4:
		///   <para />
		///   Read the source file and put half of its content into destination file
		/// </summary>
		/// <param name="source">the path to the source file</param>
		/// <param name="destination">the path to the destination file</param>
		public static void CopyHalfFile(string source, string destination)
		{
			if (!File.Exists(source))
				throw new Exception("could not open file:" + source);
			
			string[] str_list = File.ReadAllLines(source);
			
			string txt = "";
			
			for (int i = 0; i < str_list.Length/2; ++i)
			{
				txt += (str_list[i]+ "\n");
			}

			File.Delete(destination);
			
			File.AppendAllText(destination,txt);

		}
	}
}