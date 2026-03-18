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
	
	[Fact(DisplayName = "Return input text given no comment symbols")]
	public async Task NoCommentSymbols_ReturnsInputText()
	{
		// Arrange
		const string inputString = "abc def g";
		
		// Act
		var result = StripCommentsSolution.StripComments(inputString, new[] { "" });

		// Assert
		Assert.Equal(inputString, result);
	}

	[Fact(DisplayName = "Return empty text given only comment")]
	public async Task OnlyComment_ReturnsEmptyText()
	{
		// Act
		var result = StripCommentsSolution.StripComments("#", new[] { "#" });

		// Assert
		Assert.Equal("", result);
	}
	
}