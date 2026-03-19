namespace StripComment;

public class StripCommentsSolution
{
	public static string StripComments(string text, string[] commentSymbols)
	{
		var commentSymbol = commentSymbols.First();

		return text.Split(commentSymbol)[0];
	}
}