using System.Threading.Tasks;
using JetBrains.Annotations;
using StripComment;
using Xunit;

namespace StripComments.Tests;

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