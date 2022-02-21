namespace Task4.GameGuessNumber;

internal class GameManager
{
	private readonly GetterMessageConfig? _messages;
	private readonly BasisGame _game;
	private readonly LevelSelection _level;
	private int _counterMoves;
	private string? _resultMove;

	internal GameManager()
	{
		_messages = ConfigLoader.LoadJson();
		_game = new BasisGame();
		_level = new LevelSelection();
	}

	internal void Start()
	{
		StartOneMove(_level, _messages!.RequestLevel!);
		RepeatMove();
		CheckLoseCondition();
	}

	private void StartOneMove(BasisGame workingObject, string message, int variable = default)
	{
		var userAnswer = Display.ConductDialogue(message, variable);
		_resultMove = workingObject.GetResult(userAnswer);

		Display.Print(_resultMove);
	}

	private void RepeatMove()
	{
		for (; (_counterMoves != _level.LimitMove) & (_resultMove != _messages!.Win); _counterMoves++)
			StartOneMove(_game, _messages!.RequestMove!, _level.LimitMove - _counterMoves);
	}

	private void CheckLoseCondition()
	{
		if ((_counterMoves == _level.LimitMove) & (_resultMove != _messages!.Win))
			Display.Print(_messages.Lose, _game.TargetNumber);
	}
}