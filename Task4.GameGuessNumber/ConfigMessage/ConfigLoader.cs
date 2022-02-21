using System.Text.Json;

namespace Task4.GameGuessNumber;

internal static class ConfigLoader
{
	private const string RelativePath = @"ConfigMessage\MessageConfig.json";
	private const string ExcessiveDebugPath = @"bin\Debug\net6.0";
	private const string ExcessiveTestsPath = @"Tests";

	private static string? _fullPath;

	internal static GetterMessageConfig? LoadJson()
	{
		GetPath();

		var dataConfig = File.ReadAllText(_fullPath!);

		return JsonSerializer.Deserialize<GetterMessageConfig>(dataConfig);
	}

	private static void GetPath()
	{
		var baseLongPath = Environment.CurrentDirectory;

		var indexExcessiveSubstring = IndexExcessivePath(baseLongPath);

		var basePath = baseLongPath[..indexExcessiveSubstring];

		_fullPath = Path.GetFullPath(RelativePath, basePath);
	}

	private static int IndexExcessivePath(string baseLongPath)
	{
		var indexDebugSubstring = baseLongPath.IndexOf(ExcessiveDebugPath, StringComparison.Ordinal);
		var indexTestsSubstring = baseLongPath.IndexOf(ExcessiveTestsPath, StringComparison.Ordinal);

		return indexTestsSubstring != -1 ? indexTestsSubstring : indexDebugSubstring;
	}
}