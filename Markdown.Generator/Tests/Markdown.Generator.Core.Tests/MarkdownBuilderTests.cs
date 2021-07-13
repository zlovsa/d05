using System;
using Xunit;
using Markdown.Generator.Core.Markdown.Elements;
using System.Linq;

namespace Markdown.Generator.Core.Tests
{
	public class MarkdownBuilderTests
	{
		[Fact]
		public void Given_CodeQuote_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup() {
			//Arrange
			var expected = new CodeQuote("code").Create();
			Markdown.MarkdownBuilder builder = new();

			//Act
			builder.CodeQuote("code");
			var actual = builder.Elements.Last().Create();

			//Assert
			Assert.Single(builder.Elements);
			Assert.Equal(expected, actual);
		}
	}
}
