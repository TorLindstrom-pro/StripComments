using JetBrains.Annotations;
using StripComment;
using Xunit;

namespace StripComments.Tests;

[TestSubject(typeof(StripCommentsSolution))]
public class StripCommentsSolutionTest
{
	[Fact(DisplayName = "Empty text returns empty text")]
	public void EmptyText_ReturnsEmptyText()
	{
		// Act
		var result = StripCommentsSolution.StripComments("", [""]);

		// Assert
		Assert.Equal("", result);
	}

	[Fact(DisplayName = "Return input text given no comment symbols")]
	public void NoCommentSymbols_ReturnsInputText()
	{
		// Arrange
		const string inputString = "abc def g";

		// Act
		var result = StripCommentsSolution.StripComments(inputString, [""]);

		// Assert
		Assert.Equal(inputString, result);
	}

	[Fact(DisplayName = "Return empty text given only comment")]
	public void OnlyComment_ReturnsEmptyText()
	{
		// Act
		var result = StripCommentsSolution.StripComments("#", ["#"]);

		// Assert
		Assert.Equal("", result);
	}

	[Fact(DisplayName = "Return empty text if input starts with comment symbol")]
	public void InputStartsWithComment_ReturnsEmptyText()
	{
		// Act
		var result = StripCommentsSolution.StripComments("# abc", ["#"]);

		// Assert
		Assert.Equal("", result);
	}

	[Fact(DisplayName = "Remove text from comment symbol")]
	public void InputWithComment_ReturnsTextUpUntilCommentSymbol()
	{
		// Act
		var result = StripCommentsSolution.StripComments("abc #", ["#"]);

		// Assert
		Assert.Equal("abc ", result);
	}

	[Fact(DisplayName = "Remove text from earliest comment symbol")]
	public void InputWithComment_ReturnsTextUpUntilEarliestCommentSymbol()
	{
		// Act
		var result = StripCommentsSolution.StripComments("abc #def |ghi", ["|","#"]);

		// Assert
		Assert.Equal("abc ", result);
	}

	[Fact(DisplayName = "Remove text after comment symbol on each textrow")]
	public void MulitlineInputWithComment_ReturnsTextUpUntilCommentSymbol()
	{
		// Act
		var result = StripCommentsSolution.StripComments(
			"""
			abc#def
			abc
			""", 
			["#"]);

		// Assert
		Assert.Equal(
			"""
			abc
			abc
			""", result);
	}

	[Fact(DisplayName = "Remove text after any comment symbol on each textrow")]
	public void MulitlineInputWithComment_ReturnsTextUpUntilDifferentCommentSymbol()
	{
		// Act
		var result = StripCommentsSolution.StripComments(
			"""
			abc#def
			abc!def
			""", 
			["#", "!"]);

		// Assert
		Assert.Equal(
			"""
			abc
			abc
			""", result);
	}
}