namespace StripComment;

public class StripCommentsSolution
{
	public static string StripComments(string text, string[] commentSymbols)
	{
		if (string.IsNullOrWhiteSpace(commentSymbols.First())) return text;

		return text.Contains(commentSymbols.First()) ? "" : text;
	}
}