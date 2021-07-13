using System;
using Xunit;
using Markdown.Generator.Core.Markdown.Elements;

namespace Markdown.Generator.Core.Tests
{
	public class ElementsTests
	{
		readonly string nl = Environment.NewLine;
		[Fact]
		public void Given_Code_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup() {
			//Arrange
			var expected = "```csharp" + nl + "some code" + nl + "```" + nl;
			Code code = new("csharp", "some code");

			//Act
			var actual = code.Create();

			//Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Given_Code_When_CodeAsParameter_Then_ReturnMarkdownCodeQuoteMarkup() {
			//Arrange
			var expected = "`code`";
			CodeQuote codeQuote = new("code");

			//Act
			var actual = codeQuote.Create();

			//Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Given_Code_When_LevelAndTextAsParameter_Then_ReturnMarkdownHeaderMarkup() {
			//Arrange
			var expected = "## header" + nl;
			Header header= new(2, "header");

			//Act
			var actual = header.Create();

			//Assert
			Assert.Equal(expected, actual);
		}
	}
}
