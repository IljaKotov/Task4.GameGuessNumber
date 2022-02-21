namespace Task4.GameGuessNumber;

internal static class Display
{
	private const string PlaceVariable = "##";

	internal static string ConductDialogue(string? message, int variable = default)
	{
		Print(message, variable);

		return GetAnswer();
	}

	internal static void Print(string? message, int variable = default)
	{
		var changedMessage = message!.Replace(PlaceVariable, variable.ToString());

		Console.WriteLine(changedMessage);
	}

	private static string GetAnswer()
	{
		var answer = Console.ReadLine();

		if (answer != null)
			return answer;

		throw new InvalidInputDataException("You enter wrong data.");
	}
}