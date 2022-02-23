using Task4.GameGuessNumber.ConfigMessage;

namespace Task4.GameGuessNumber.GameBody;

internal class BasisGame
{
	private const int MinNumber = 0;
	private const int MaxNumber = 101;
	private const int WrongResult = -1357;

	internal GetterMessageConfig? Messages { get; }
	internal int TargetNumber { get; }

	internal BasisGame()
	{
		TargetNumber = Random.Shared.Next(MinNumber, MaxNumber);
		Messages = ConfigLoader.LoadJson();
	}

	internal BasisGame(int targetNumber)
	{
		TargetNumber = targetNumber;
		Messages = ConfigLoader.LoadJson();
	}

	protected virtual string? AnalysisMove(int parsedAnswer)
	{
		if (parsedAnswer == TargetNumber)
			return Messages!.Win;

		if (parsedAnswer == WrongResult)
			return Messages!.ExceptionData;

		return parsedAnswer < TargetNumber ? Messages!.ResultMoveIsLess : Messages!.ResultMoveIsGreater;
	}

	internal string? GetResult(string userAnswer)
	{
		var parsedAnswer = ParseUserAnswer(userAnswer);

		return AnalysisMove(parsedAnswer);
	}

	private static int ParseUserAnswer(string userAnswer)
	{
		return int.TryParse(userAnswer, out var parsedAnswer) ? parsedAnswer : WrongResult;
	}
}