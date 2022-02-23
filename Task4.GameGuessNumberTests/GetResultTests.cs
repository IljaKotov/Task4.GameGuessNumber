using NUnit.Framework;
using Task4.GameGuessNumber.GameBody;

namespace Task4.GameGuessNumberTests;

public class GetResultTests
{
	[Test]
	public void GetResult_Null_MessageExceptionData()
	{
		const int targetNumber = 50;
		const string expectedNumber = null!;

		var testGame = new BasisGame(targetNumber);
		var expectedMessage = testGame.Messages!.ExceptionData;

		var actualMessage = testGame.GetResult(expectedNumber!);
		Assert.AreEqual(expectedMessage, actualMessage);
	}

	[Test]
	public void GetResult_InvalidInputData_MessageExceptionData()
	{
		const int targetNumber = 50;
		const string expectedNumber = "wwe12";

		var testGame = new BasisGame(targetNumber);
		var expectedMessage = testGame.Messages!.ExceptionData;

		var actualMessage = testGame.GetResult(expectedNumber!);
		Assert.AreEqual(expectedMessage, actualMessage);
	}

	[Test]
	public void GetResult_4IsLessNumber_MessageResultMoveIsLess()
	{
		const int targetNumber = 50;
		const string expectedNumber = "4";

		var testGame = new BasisGame(targetNumber);
		var expectedMessage = testGame.Messages!.ResultMoveIsLess;

		var actualMessage = testGame.GetResult(expectedNumber);
		Assert.AreEqual(expectedMessage, actualMessage);
	}

	[Test]
	public void GetResult_66IsGreaterNumber_MessageResultMoveIsGreater()
	{
		const int targetNumber = 50;
		const string expectedNumber = "66";

		var testGame = new BasisGame(targetNumber);
		var expectedMessage = testGame.Messages!.ResultMoveIsGreater;

		var actualMessage = testGame.GetResult(expectedNumber);
		Assert.AreEqual(expectedMessage, actualMessage);
	}

	[Test]
	public void GetResult_50IsTargetNumber_MessageWin()
	{
		const int targetNumber = 50;
		const string expectedNumber = "50";

		var testGame = new BasisGame(targetNumber);
		var expectedMessage = testGame.Messages!.Win;

		var actualMessage = testGame.GetResult(expectedNumber);
		Assert.AreEqual(expectedMessage, actualMessage);
	}
}