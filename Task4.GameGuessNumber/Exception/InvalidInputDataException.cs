namespace Task4.GameGuessNumber;

internal class InvalidInputDataException : Exception
{
	internal InvalidInputDataException(string? message)
		: base(message)
	{
	}
}