using System;
using Xunit;
using Markdown.Generator.Core.Markdown.Elements;
using System.Linq;

namespace Markdown.Generator.Core.Tests
{
	public class Sut
	{
		public void PublicMethod() { }
		private void PrivateMethod() { }
	}

	public class MarkdownableTypeTests
	{
		[Fact]
		public void Given_Sut_When_GetMethods_Then_ReturnPublicOnly() {
			//Arrange
			Markdown.MarkdownableType markdownableType = new Markdown.MarkdownableType(typeof(Sut), null);
			var expected = false;

			//Act
			var methods = markdownableType.GetMethods();
			var actual = methods[0].IsPrivate;

			//Assert
			Assert.Single(methods);
			Assert.Equal(expected, actual);
		}
	}
}
