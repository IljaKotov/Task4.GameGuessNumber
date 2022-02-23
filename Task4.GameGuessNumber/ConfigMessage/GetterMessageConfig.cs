namespace Task4.GameGuessNumber.ConfigMessage;

public record GetterMessageConfig
{
	public string RequestLevel { get; set; } = null!;
	public string Win { get; set; }= null!;
	public string Lose { get; set; }= null!;
	public string ExceptionData { get; set; }= null!;
	public string RequestMove { get; set; }= null!;
	public string ResultMoveIsLess { get; set; }= null!;
	public string ResultMoveIsGreater { get; set; }= null!;
	public string RequestNewGame { get; set; }= null!;
	public string LevelChosen { get; set; }= null!;
	public string PlaceVariable { get; set; }= null!;
	public string StopRepeat { get; set; }= null!;
}