using Task4.GameGuessNumber.ConfigMessage;

namespace Task4.GameGuessNumber.GameBody;

internal class GameRepeater : BasisGame
{
	private const int RepeatConfirmation = 1;
	private readonly GetterMessageConfig? _messages;
	internal bool Repeater { get; private set; }

	internal GameRepeater()
	{
		_messages = ConfigLoader.LoadJson();
		Repeater = true;
	}

	protected override string? AnalysisMove(int parsedAnswer)
	{
		if (parsedAnswer != RepeatConfirmation)
			Repeater = false;

		return _messages!.StopRepeat;
	}
}