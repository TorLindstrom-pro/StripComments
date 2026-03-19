namespace StripComment;

public class StripCommentsSolution
{
	public static string StripComments(string text, string[] commentSymbols)
	{
		var inputRows = text.Split("\n");

		var cleanedRows = inputRows.Select(row =>
		{
			var firstCommentSymbol = commentSymbols
				.Where(row.Contains)
				.OrderBy(symbol => row.IndexOf(symbol))
				.FirstOrDefault();

			return row.Split(firstCommentSymbol)[0];
		});

		return string.Join("\r\n", cleanedRows);
	}
}