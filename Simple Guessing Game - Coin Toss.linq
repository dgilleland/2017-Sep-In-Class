<Query Kind="Program" />

// A "global" item
Random rnd = new Random();

void Main()
{
	Console.WriteLine("Play a guessing game");
	Console.WriteLine("====================");
	
	int correctAnswers = 0;
	string coinFace;
	
	Console.WriteLine("\nYou have 10 turns.\n");
	for(int count = 0; count < 10; count++)
	{
		if(rnd.Next(2) == 0)
			coinFace = "heads";
		else
			coinFace = "tails";
		
		Console.WriteLine("Enter 'Heads' or 'Tails':");
		string answer = Console.ReadLine();
		Console.Write("\tYou guessed " + answer);
		if(coinFace == answer.ToLower())
		{
			Console.WriteLine(" and you were correct");
		    correctAnswers++;
		}
		else
		    Console.WriteLine(" but you were incorrect");
	}
	Console.WriteLine("\nYou got " + correctAnswers + " right answers");
	
}

// Define other methods and classes here
