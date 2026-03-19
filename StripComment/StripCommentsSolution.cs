using System.Linq;

namespace StripComment;

public class StripCommentsSolution
{
	public static string StripComments(string text, string[] commentSymbols)
	{
		var cleanedRows = text
			.Split("\n")
			.Select(row =>
				row.Split(commentSymbols
						.OrderBy(row.IndexOf)
						.FirstOrDefault(row.Contains)
					)[0]
					.TrimEnd());

		return string.Join("\r\n", cleanedRows);
	}
}