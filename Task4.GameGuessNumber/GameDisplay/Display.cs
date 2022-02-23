namespace Task4.GameGuessNumber.GameDisplay;

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

		return CheckNull(answer!);
	}

	private static string CheckNull(string? answer)
	{
		if (answer != null)
			return answer;

		Print("You enter wrong data. Try it again, please:");

		return GetAnswer();
	}
}