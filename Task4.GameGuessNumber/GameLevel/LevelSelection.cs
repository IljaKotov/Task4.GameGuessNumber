namespace Task4.GameGuessNumber;

internal class LevelSelection : BasisGame
{
	private readonly GetterMessageConfig? _message;

	internal int LimitMove { get; private set; }

	internal LevelSelection()
	{
		_message = ConfigLoader.LoadJson();
	}

	protected override string AnalysisMove(int parseLevel)
	{
		LimitMove = parseLevel + LevelsConfig.ChoiceToLimit;

		var levelName = GetNameLevel(parseLevel);

		return GetLevelMessage(parseLevel, levelName);
	}

	private static string GetNameLevel(int parseLevel)
	{
		return parseLevel switch
		{
			1 => "hard",
			2 => "medium",
			3 => "easy",
			_ => string.Empty
		};
	}

	private string GetLevelMessage(int parseLevel, string levelName)
	{
		if ((parseLevel > LevelsConfig.ChoiceMin) & (parseLevel < LevelsConfig.ChoiceMax))
			return $"{_message!.LevelChosen!.Replace(_message.PlaceVariable!, levelName)}";

		throw new InvalidInputDataException(_message!.ExceptionLevel);
	}
}