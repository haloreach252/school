using System;

namespace NumberGuesser {
	class Program {
		static void Main(string[] args) {
			int min = 0, max = 0;
			if (args.Length == 2) {
				int.TryParse(args[0], out min);
				int.TryParse(args[1], out max);
			}

			if (min == 0) min = 1;  if (max == 0) max = 100;
			if (min >= max) min = max - 1;
			new Program().Game(min, max);
		}

		private void Game(int min, int max) {
			Console.WriteLine("Guess a number");
			int ran = new Random().Next(min, max + 1), attempts = 1, ans;
			int.TryParse(Console.ReadLine(), out ans);
			while (ans != ran) {
				attempts++;
				Console.WriteLine(ans > ran ? $"You guessed {ans}. Thats too big!" : $"You guessed {ans}. Thats too small");
				int.TryParse(Console.ReadLine(), out ans);
			}
			Console.WriteLine($"You guessed {ans}. You won! It took {attempts} attempts.\nPlay again (yes/no)?");
			if(Console.ReadLine().ToLower() == "yes") Game(min, max);
			else return;
		}

	}
}
