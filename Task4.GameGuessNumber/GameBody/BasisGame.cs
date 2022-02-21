namespace Task4.GameGuessNumber;

internal class BasisGame
{
	private const int MinNumber = 0;
	private const int MaxNumber = 101;

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

		return parsedAnswer < TargetNumber ? Messages!.ResultMoveIsLess : Messages!.ResultMoveIsGreater;
	}

	internal string? GetResult(string userAnswer)
	{
		var parsedAnswer = ParseUserAnswer(userAnswer);

		return AnalysisMove(parsedAnswer);
	}

	private int ParseUserAnswer(string userAnswer)
	{
		if (int.TryParse(userAnswer, out var parsedAnswer))
			return parsedAnswer;

		throw new InvalidInputDataException(Messages!.ExceptionData);
	}
}