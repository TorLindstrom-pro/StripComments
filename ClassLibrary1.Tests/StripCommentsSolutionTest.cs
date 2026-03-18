using System.Threading.Tasks;
using ClassLibrary1;
using JetBrains.Annotations;
using Xunit;

namespace ClassLibrary1.Tests;

[TestSubject(typeof(StripCommentsSolution))]
public class StripCommentsSolutionTest
{
	[Fact(DisplayName = "Empty text returns empty text")]
	public async Task EmptyText_ReturnsEmptyText()
	{
		// Act
		var result = StripCommentsSolution.StripComments("", new[] { "" });

		// Assert
		Assert.Equal("", result);
	}
}