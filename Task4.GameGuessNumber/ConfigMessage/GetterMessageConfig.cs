namespace Task4.GameGuessNumber;

public record GetterMessageConfig
{
	public string? RequestLevel { get; set; }
	public string? Win { get; set; }
	public string? Lose { get; set; }
	public string? ExceptionLevel { get; set; }
	public string? ExceptionData { get; set; }
	public string? RequestMove { get; set; }
	public string? ResultMoveIsLess { get; set; }
	public string? ResultMoveIsGreater { get; set; }
	public string? RequestNewGame { get; set; }
	public string? LevelChosen { get; set; }
	public string? PlaceVariable { get; set; }
	public string? StopRepeat { get; set; }
}