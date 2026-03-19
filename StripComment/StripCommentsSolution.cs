namespace StripComment;

public class StripCommentsSolution
{
	public static string StripComments(string text, string[] commentSymbols)
	{
		var commentSymbol = commentSymbols.First();

		var inputRows = text.Split("\n");

		return string.Join("\r\n", inputRows.Select(row => row.Split(commentSymbol)[0]));
	}
}