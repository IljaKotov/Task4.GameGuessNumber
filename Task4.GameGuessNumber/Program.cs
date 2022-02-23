using Task4.GameGuessNumber.ConfigMessage;
using Task4.GameGuessNumber.GameBody;
using Task4.GameGuessNumber.GameDisplay;

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