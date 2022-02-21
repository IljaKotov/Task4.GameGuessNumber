using Task4.GameGuessNumber;

var gameRestart = new GameRepeater();
var message = ConfigLoader.LoadJson();

while (gameRestart.Repeater)
{
	new GameManager().Start();
	RequestRepeatGame();
}

void RequestRepeatGame()
{
	var answerRepeat = Display.ConductDialogue(message!.RequestNewGame);
	gameRestart.GetResult(answerRepeat);
}
