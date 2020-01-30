using System;

namespace PigLatin {
	class Program {
		static void Main(string[] args) {
			string str1, str2;
			Console.WriteLine("Enter a word to pig latinify: ");
			str1 = Console.ReadLine();
			str2 = str1.Substring(0, 1);
			Console.WriteLine($"Your new word is: {str1.Substring(1)} {str2}ay");
			Console.ReadKey();
		}
	}
}